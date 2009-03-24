using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MacroScope
{
    /// <summary>
    /// Represents a datetime literal.
    /// </summary>
    /// <remarks>
    /// Times represented by instances of this class are in (whole) seconds.
    /// </remarks>
    public sealed class LiteralDateTime : INode
    {
        #region Fields

        private readonly string m_bareLiteral;

        private char m_delimiter;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance from a string literal.
        /// </summary>
        /// <param name="literal">
        /// The datetime, either in a subset of
        /// ISO 8601 format - either <c>yyyy-MM-ddTHH:mm:ss</c>
        /// or <c>yyyy-MM-dd HH:mm:ss</c> - or in a format accepted by MS Access,
        /// that is <c>#yyyy-MM-dd HH:mm:ss#</c>.
        /// </param>
        public LiteralDateTime(string literal)
        {
            Validate(literal);

            if (literal[0] == '#')
            {
                m_bareLiteral = literal.Substring(1, literal.Length - 2);
            }
            else
            {
                m_bareLiteral = Regex.Replace(literal, "T", " ",
                    RegexOptions.IgnoreCase);
            }

            m_delimiter = 'T';
        }

        /// <summary>
        /// Constructs a new instance from .NET timestamp.
        /// </summary>
        /// <param name="dateTime">
        /// The timestamp the new instance represents.
        /// </param>
        public LiteralDateTime(DateTime dateTime)
        {
            m_bareLiteral = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            m_delimiter = 'T';
        }

        /// <summary>
        /// Constructs a new instance from an SQL string.
        /// </summary>
        /// <param name="stringValue">
        /// The string literal.
        /// </param>
        public LiteralDateTime(StringValue stringValue)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException("stringValue");
            }

            Validate(stringValue.Value);

            m_bareLiteral = Regex.Replace(stringValue.Value, "T", " ",
                RegexOptions.IgnoreCase);
            m_delimiter = '\'';
        }

        #endregion

        #region Properties

        /// <summary>
        /// Valid values are '#' for MS Access formatting, or
        /// ' ', 't' or 'T' (the default) for ISO8601, or
        /// '\'' for SQL TIMESTAMP.
        /// </summary>
        public char Delimiter
        {
            get
            {
                return m_delimiter;
            }

            set
            {
                if ((value != '#') && (value != ' ') && (value != 't') &&
                    (value != 'T') && (value != '\''))
                {
                    string message = string.Format("Invalid date delimiter {0}.",
                        value);
                    throw new ArgumentException(message, "value");
                }

                m_delimiter = value;
            }
        }

        public string Literal
        {
            get
            {
                if (m_delimiter == '#')
                {
                    return string.Format("#{0}#", m_bareLiteral);
                }
                else if (m_delimiter == ' ')
                {
                    return m_bareLiteral;
                }
                else if (m_delimiter == '\'')
                {
                    return string.Format("{0} '{1}'", TailorUtil.TIMESTAMP.ToUpperInvariant(),
                        m_bareLiteral);
                }
                else
                {
                    return Regex.Replace(m_bareLiteral, " ", m_delimiter.ToString());
                }
            }
        }

        public DateTime DateTime
        {
            get
            {
                return DateTime.ParseExact(m_bareLiteral,
                    "yyyy-MM-dd HH:mm:ss",
                    null);
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new LiteralDateTime(m_bareLiteral);
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.Perform(this);
        }

        #endregion

        #region Validation

        private static void Validate(string literal)
        {
            if (literal == null)
            {
                throw new ArgumentNullException("literal");
            }

            if (literal.Length < 18)
            {
                string message = string.Format("Literal datetime {0} too short.",
                    literal);
                throw new ArgumentException(message);
            }

            string inner;
            if (literal[0] == '#')
            {
                if (literal[literal.Length - 1] != '#')
                {
                    string message = string.Format("Literal date {0} is not quoted.",
                        literal);
                    throw new ArgumentException(message);
                }

                inner = literal.Substring(1, literal.Length - 2);
            }
            else
            {
                inner = literal;
            }

            if (!Regex.IsMatch(inner, "^\\d\\d\\d\\d-\\d\\d-\\d\\d[ t]\\d\\d:\\d\\d:\\d\\d$",
                RegexOptions.IgnoreCase))
            {
                string message = string.Format("Literal datetime {0} has unknown format.",
                    literal);
                throw new ArgumentException(message);
            }
        }

        #endregion
    }
}
