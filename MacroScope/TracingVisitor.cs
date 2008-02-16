using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// Maintains backlinks to <see cref="INode"/> parent during
    /// traversal.
    /// </summary>
    public class TracingVisitor : PassiveVisitor
    {
        #region Fields

        private readonly List<INode> m_ancestors;

        #endregion

        #region Constructor

        public TracingVisitor()
        {
            m_ancestors = new List<INode>();
        }

        #endregion

        #region Parent maintenance

        /// <summary>
        /// Parent of the currently traversed node if it has one, null otherwise.
        /// </summary>
        public INode Parent
        {
            get
            {
                INode parent = null;
                if (m_ancestors.Count > 0)
                {
                    parent = m_ancestors[m_ancestors.Count - 1];
                    Debug.Assert(parent != null);
                }

                return parent;
            }
        }

        public void PushParent(INode parent)
        {
            if (parent == null)
            {
                throw new ArgumentNullException("parent");
            }

            m_ancestors.Add(parent);
        }

        public INode PopParent()
        {
            if (m_ancestors.Count == 0)
            {
                throw new InvalidOperationException("No parent to pop.");
            }

            int last = m_ancestors.Count - 1;
            INode parent = m_ancestors[last];
            Debug.Assert(parent != null);
            m_ancestors.RemoveAt(last);
            return parent;
        }

        public INode GetParent(INode child)
        {
            if (child == null)
            {
                return Parent;
            }

            for (int i = m_ancestors.Count - 1; i > 0; --i)
            {
                Debug.Assert(m_ancestors[i] != null);
                if (m_ancestors[i] == child)
                {
                    INode parent = m_ancestors[i - 1];
                    Debug.Assert(parent != null);
                    return parent;
                }
            }

            return null;
        }

        public Node GetAncestor<Node>(INode child, INode parent) where Node : class
        {
            bool foundStart = child == null;
            for (int i = m_ancestors.Count - 1; i >= 0; --i)
            {
                Debug.Assert(m_ancestors[i] != null);
                if (m_ancestors[i] == parent)
                {
                    return null;
                }

                if (foundStart)
                {
                    Node n = m_ancestors[i] as Node;
                    if (n != null)
                    {
                        return n;
                    }
                }
                else
                {
                    if (m_ancestors[i] == child)
                    {
                        foundStart = true;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Replaces <paramref name="oldChild"/> by <paramref name="newChild"/>
        /// in an expression which is <paramref name="oldChild"/>'s parent.
        /// </summary>
        /// <param name="oldChild">
        /// The node to remove from the tree. Must not be null.
        /// </param>
        /// <param name="newChild">
        /// The node to add to the tree. Must not be null.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current <see cref="Parent"/> isn't an
        /// <see cref="Expression"/>, or when <paramref name="oldChild"/>
        /// isn't the child of <see cref="Parent"/>.
        /// </exception>
        public void ReplaceTerm(INode oldChild, INode newChild)
        {
            if (oldChild == null)
            {
                throw new ArgumentNullException("oldChild");
            }

            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }

            Expression parent = Parent as Expression;
            if (parent != null)
            {
                if (parent.Left == oldChild)
                {
                    parent.Left = newChild;
                }
                else if (parent.Right == oldChild)
                {
                    parent.Right = newChild;
                }
                else
                {
                    throw new InvalidOperationException("No child found in expression parent.");
                }
            }
            else
            {
                throw new InvalidOperationException("Term not in expression.");
            }
        }

        #endregion

        #region IVisitor Members

        public override void PerformBefore(AliasedItem node)
        {
            PushParent(node);
        }

        public override void PerformAfter(AliasedItem node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(Assignment node)
        {
            PushParent(node);
        }

        public override void PerformAfter(Assignment node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(BracketedExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(BracketedExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(CaseAlternative node)
        {
            PushParent(node);
        }

        public override void PerformAfter(CaseAlternative node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(CaseExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(CaseExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(DbObject node)
        {
            PushParent(node);
        }

        public override void PerformAfter(DbObject node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(DeleteStatement node)
        {
            PushParent(node);
        }

        public override void PerformAfter(DeleteStatement node)
        {
            PopKnownParent(node);
            Debug.Assert(m_ancestors.Count == 0);
        }

        public override void PerformBefore(Expression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(Expression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(ExpressionItem node)
        {
            PushParent(node);
        }

        public override void PerformAfter(ExpressionItem node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(ExtractFunction node)
        {
            PushParent(node);
        }

        public override void PerformAfter(ExtractFunction node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(FunctionCall node)
        {
            PushParent(node);
        }

        public override void PerformAfter(FunctionCall node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(GroupByClause node)
        {
            PushParent(node);
        }

        public override void PerformAfter(GroupByClause node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(InsertStatement node)
        {
            PushParent(node);
        }

        public override void PerformAfter(InsertStatement node)
        {
            PopKnownParent(node);
            Debug.Assert(m_ancestors.Count == 0);
        }

        public override void PerformBefore(Interval node)
        {
            PushParent(node);
        }

        public override void PerformAfter(Interval node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(OrderExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(OrderExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(PatternExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(PatternExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(PredicateExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(PredicateExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(QueryExpression node)
        {
            PushParent(node);
        }

        public override void PerformAfter(QueryExpression node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(Range node)
        {
            PushParent(node);
        }

        public override void PerformAfter(Range node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(SelectStatement node)
        {
            PushParent(node);
        }

        public override void PerformAfter(SelectStatement node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(SwitchFunction node)
        {
            PushParent(node);
        }

        public override void PerformAfter(SwitchFunction node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(Table node)
        {
            PushParent(node);
        }

        public override void PerformAfter(Table node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(TableWildcard node)
        {
            PushParent(node);
        }

        public override void PerformAfter(TableWildcard node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(TypeCast node)
        {
            PushParent(node);
        }

        public override void PerformAfter(TypeCast node)
        {
            PopKnownParent(node);
        }

        public override void PerformBefore(UpdateStatement node)
        {
            PushParent(node);
        }

        public override void PerformAfter(UpdateStatement node)
        {
            PopKnownParent(node);
            Debug.Assert(m_ancestors.Count == 0);
        }

        #endregion

        #region Utilities

        void PopKnownParent(INode node)
        {
            INode parent = PopParent();
            Debug.Assert(node == parent);
        }

        #endregion
    }
}
