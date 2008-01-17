using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents an SQL expression - both arithmetic and logical.
    /// </summary>
    /// <remarks>
    /// Since expressions are built in recursive steps, some states
    /// of Expression objects do not correspond to valid expressions.
    /// Such objects cannot be used until fully constructed.
    /// </remarks>
    public sealed class Expression : IExpression
    {
        #region Fields

        private INode m_left;

        private ExpressionOperator m_operator;

        private INode m_right;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an empty (not fully constructed) expression.
        /// </summary>
        public Expression()
        {
        }

        /// <summary>
        /// Creates a fully constructed binary expression.
        /// </summary>
        /// <param name="left">
        /// The left sub-expression. Must not be null.
        /// </param>
        /// <param name="op">
        /// The operator. Must be a non-null binary operator.
        /// </param>
        /// <param name="right">
        /// The right sub-expression. Must not be null.
        /// </param>
        public Expression(INode left, ExpressionOperator op, INode right)
        {
            if (left == null)
            {
                throw new ArgumentNullException("left");
            }

            if (op == null)
            {
                throw new ArgumentNullException("op");
            }

            if (right == null)
            {
                throw new ArgumentNullException("right");
            }

            m_left = left;
            m_operator = op;
            m_right = right;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sub-expression of this instance, or null.
        /// </summary>
        /// <remarks>
        /// Fully-constructed expressions must have either left or
        /// <see cref="Right"/> sub-expression (or both), depending
        /// on their <see cref="Operator"/>.
        /// </remarks>
        public INode Left
        {
            get { return m_left; }
            set { m_left = value; }
        }

        /// <summary>
        /// An operator instance (if this expression is an operator expression),
        /// or null.
        /// </summary>
        /// <remarks>
        /// Expressions don't have to have an operator, but fully-constructed
        /// expressions without an operator must have exactly one sub-expression
        /// (either <see cref="Left"/> or <see cref="Right"/>). Valid operator
        /// is interpreted as a prefix operator of objects with <see cref="Right"/>
        /// but not <see cref="Left"/> sub-expression, as a suffix operator
        /// of objects with <see cref="Left"/> but not <see cref="Right"/> sub-expression
        /// and as a binary operator of objects with both <see cref="Left"/>
        /// and <see cref="Right"/> sub-expressions.
        /// </remarks>
        public ExpressionOperator Operator
        {
            get { return m_operator; }
            set { m_operator = value; }
        }

        /// <summary>
        /// Sub-expression of this instance, or null.
        /// </summary>
        /// <remarks>
        /// Fully-constructed expressions must have either <see cref="Left"/> or
        /// right sub-expression (or both), depending on their <see cref="Operator"/>.
        /// </remarks>
        public INode Right
        {
            get { return m_right; }
            set { m_right = value; }
        }

        /// <summary>
        /// Should use parentheses when part of a larger expression?
        /// </summary>
        /// <remarks>
        /// Only valid for fully-constructed expressions.
        /// </remarks>
        public bool IsComposed
        {
            get
            {
                if (m_operator != null)
                {
                    return true;
                }

                if (m_left != null)
                {
                    IExpression left = m_left as IExpression;
                    if (left != null)
                    {
                        return left.IsComposed;
                    }
                }

                IExpression right = m_right as IExpression;
                if (right != null)
                {
                    return right.IsComposed;
                }

                return false;
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            Expression expression = new Expression();

            if (m_left != null)
            {
                expression.Left = m_left.Clone();
            }

            if (m_operator != null)
            {
                expression.Operator = (ExpressionOperator)(m_operator.Clone());
            }

            if (m_right != null)
            {
                expression.Right = m_right.Clone();
            }

            return expression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);

            if (m_operator == null)
            {
                if (m_left == null)
                {
                    if (m_right == null)
                    {
                        throw new InvalidOperationException(
                            "Expression not set.");
                    }
                    else
                    {
                        m_right.Traverse(visitor);
                    }
                }
                else
                {
                    if (m_right == null)
                    {
                        m_left.Traverse(visitor);
                    }
                    else
                    {
                        throw new InvalidOperationException(
                            "Binary expression must have an operator.");
                    }
                }
            }
            else
            {
                if (m_left == null)
                {
                    if (m_right == null)
                    {
                        throw new InvalidOperationException(
                            "Operator expression must have an argument.");
                    }
                    else
                    {
                        visitor.PerformBeforePrefixOp(this);
                        m_operator.Traverse(visitor);
                        visitor.PerformAfterPrefixOp(this);
                        m_right.Traverse(visitor);
                    }
                }
                else
                {
                    if (m_right == null)
                    {
                        m_left.Traverse(visitor);
                        visitor.PerformBeforePostfixOp(this);
                        m_operator.Traverse(visitor);
                        visitor.PerformAfterPostfixOp(this);
                    }
                    else
                    {
                        m_left.Traverse(visitor);
                        visitor.PerformBeforeBinaryOp(this);

                        if (m_operator != null) // it wasn't null, at the start
                                                // of this method, but some visitors
                                                // (i.e. MTailor) like to reset them...
                        {
                            m_operator.Traverse(visitor);
                        }

                        visitor.PerformAfterBinaryOp(this);

                        if (m_right != null)
                        {
                            m_right.Traverse(visitor);
                        }
                    }
                }
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
