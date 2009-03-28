// $ANTLR 3.1.2 MacroScope\\MacroScope.g 2009-03-25 09:39:28

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
	MacroScope

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public partial class MacroScopeLexer : Lexer {
    public const int CAST = 62;
    public const int STAR = 40;
    public const int MOD = 77;
    public const int GREATERTHANOREQUALTO1 = 82;
    public const int DOT_STAR = 50;
    public const int CASE = 57;
    public const int DAY = 87;
    public const int NOT = 30;
    public const int ASSIGNEQUAL = 14;
    public const int EOF = -1;
    public const int MONTH = 86;
    public const int RPAREN = 7;
    public const int FULL = 44;
    public const int Variable = 52;
    public const int ESCAPE = 34;
    public const int INSERT = 4;
    public const int NonQuotedIdentifier = 56;
    public const int SELECT = 16;
    public const int INTO = 5;
    public const int DIVIDE = 76;
    public const int PLACEHOLDER = 51;
    public const int GREATERTHAN = 83;
    public const int SECOND = 90;
    public const int ASC = 24;
    public const int UnicodeStringLiteral = 64;
    public const int NULL = 32;
    public const int ELSE = 60;
    public const int ON = 48;
    public const int DELETE = 11;
    public const int GROUP = 26;
    public const int MAccessDateTime = 69;
    public const int OR = 28;
    public const int LESSTHANOREQUALTO1 = 80;
    public const int END = 61;
    public const int FROM = 12;
    public const int DISTINCT = 18;
    public const int Letter = 91;
    public const int TIMESTAMP = 71;
    public const int WHERE = 21;
    public const int UnicodeStringRun = 97;
    public const int INNER = 41;
    public const int YEAR = 85;
    public const int ORDER = 22;
    public const int UPDATE = 9;
    public const int AsciiStringLiteral = 65;
    public const int Exponent = 93;
    public const int FOR = 54;
    public const int AND = 29;
    public const int CROSS = 47;
    public const int INTERVAL = 72;
    public const int LPAREN = 6;
    public const int AS = 49;
    public const int IN = 36;
    public const int THEN = 59;
    public const int Number = 94;
    public const int COMMA = 13;
    public const int IS = 31;
    public const int LEFT = 42;
    public const int SOME = 38;
    public const int ALL = 17;
    public const int Real = 67;
    public const int PLUS = 73;
    public const int EXISTS = 37;
    public const int EXTRACT = 55;
    public const int DOT = 63;
    public const int Whitespace = 99;
    public const int LIKE = 33;
    public const int OUTER = 45;
    public const int HexLiteral = 68;
    public const int BY = 23;
    public const int LESSTHAN = 81;
    public const int AsciiStringRun = 96;
    public const int DEFAULT = 15;
    public const int VALUES = 8;
    public const int RIGHT = 43;
    public const int SET = 10;
    public const int HAVING = 27;
    public const int MINUS = 74;
    public const int Digit = 92;
    public const int HOUR = 88;
    public const int QuotedIdentifier = 66;
    public const int WordTail = 95;
    public const int JOIN = 46;
    public const int UNION = 84;
    public const int SUBSTRING = 53;
    public const int COLON = 98;
    public const int STRCONCAT = 75;
    public const int ANY = 39;
    public const int WHEN = 58;
    public const int NOTEQUAL1 = 78;
    public const int NOTEQUAL2 = 79;
    public const int DESC = 25;
    public const int MINUTE = 89;
    public const int TOP = 19;
    public const int BETWEEN = 35;
    public const int Integer = 20;
    public const int Iso8601DateTime = 70;

    	public override void ReportError(RecognitionException e)
    	{
    	}


    // delegates
    // delegators

    public MacroScopeLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MacroScopeLexer(ICharStream input)
		: this(input, null) {
    }
    public MacroScopeLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "MacroScope\\MacroScope.g";} 
    }

    // $ANTLR start "ALL"
    public void mALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:803:5: ( 'all' )
            // MacroScope\\MacroScope.g:803:7: 'all'
            {
            	Match("all"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALL"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:804:5: ( 'and' )
            // MacroScope\\MacroScope.g:804:7: 'and'
            {
            	Match("and"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "ANY"
    public void mANY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ANY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:805:5: ( 'any' )
            // MacroScope\\MacroScope.g:805:7: 'any'
            {
            	Match("any"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ANY"

    // $ANTLR start "AS"
    public void mAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:806:4: ( 'as' )
            // MacroScope\\MacroScope.g:806:6: 'as'
            {
            	Match("as"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AS"

    // $ANTLR start "ASC"
    public void mASC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:807:5: ( 'asc' )
            // MacroScope\\MacroScope.g:807:7: 'asc'
            {
            	Match("asc"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASC"

    // $ANTLR start "BETWEEN"
    public void mBETWEEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BETWEEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:808:9: ( 'between' )
            // MacroScope\\MacroScope.g:808:11: 'between'
            {
            	Match("between"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BETWEEN"

    // $ANTLR start "BY"
    public void mBY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:809:4: ( 'by' )
            // MacroScope\\MacroScope.g:809:6: 'by'
            {
            	Match("by"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BY"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:810:6: ( 'case' )
            // MacroScope\\MacroScope.g:810:8: 'case'
            {
            	Match("case"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "CAST"
    public void mCAST() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CAST;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:811:6: ( 'cast' )
            // MacroScope\\MacroScope.g:811:8: 'cast'
            {
            	Match("cast"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CAST"

    // $ANTLR start "CROSS"
    public void mCROSS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CROSS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:812:7: ( 'cross' )
            // MacroScope\\MacroScope.g:812:9: 'cross'
            {
            	Match("cross"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CROSS"

    // $ANTLR start "DAY"
    public void mDAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:813:5: ( 'day' )
            // MacroScope\\MacroScope.g:813:7: 'day'
            {
            	Match("day"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DAY"

    // $ANTLR start "DEFAULT"
    public void mDEFAULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DEFAULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:814:9: ( 'default' )
            // MacroScope\\MacroScope.g:814:11: 'default'
            {
            	Match("default"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DEFAULT"

    // $ANTLR start "DELETE"
    public void mDELETE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DELETE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:815:8: ( 'delete' )
            // MacroScope\\MacroScope.g:815:10: 'delete'
            {
            	Match("delete"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DELETE"

    // $ANTLR start "DESC"
    public void mDESC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DESC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:816:6: ( 'desc' )
            // MacroScope\\MacroScope.g:816:8: 'desc'
            {
            	Match("desc"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DESC"

    // $ANTLR start "DISTINCT"
    public void mDISTINCT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DISTINCT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:817:10: ( 'distinct' )
            // MacroScope\\MacroScope.g:817:12: 'distinct'
            {
            	Match("distinct"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DISTINCT"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:818:6: ( 'else' )
            // MacroScope\\MacroScope.g:818:8: 'else'
            {
            	Match("else"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:819:5: ( 'end' )
            // MacroScope\\MacroScope.g:819:7: 'end'
            {
            	Match("end"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "ESCAPE"
    public void mESCAPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ESCAPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:820:8: ( 'escape' )
            // MacroScope\\MacroScope.g:820:10: 'escape'
            {
            	Match("escape"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESCAPE"

    // $ANTLR start "EXISTS"
    public void mEXISTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXISTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:821:8: ( 'exists' )
            // MacroScope\\MacroScope.g:821:10: 'exists'
            {
            	Match("exists"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXISTS"

    // $ANTLR start "EXTRACT"
    public void mEXTRACT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXTRACT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:822:9: ( 'extract' )
            // MacroScope\\MacroScope.g:822:11: 'extract'
            {
            	Match("extract"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXTRACT"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:823:5: ( 'for' )
            // MacroScope\\MacroScope.g:823:7: 'for'
            {
            	Match("for"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "FROM"
    public void mFROM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FROM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:824:6: ( 'from' )
            // MacroScope\\MacroScope.g:824:8: 'from'
            {
            	Match("from"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FROM"

    // $ANTLR start "FULL"
    public void mFULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:825:6: ( 'full' )
            // MacroScope\\MacroScope.g:825:8: 'full'
            {
            	Match("full"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FULL"

    // $ANTLR start "GROUP"
    public void mGROUP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GROUP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:826:7: ( 'group' )
            // MacroScope\\MacroScope.g:826:9: 'group'
            {
            	Match("group"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GROUP"

    // $ANTLR start "HAVING"
    public void mHAVING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = HAVING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:827:8: ( 'having' )
            // MacroScope\\MacroScope.g:827:10: 'having'
            {
            	Match("having"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "HAVING"

    // $ANTLR start "HOUR"
    public void mHOUR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = HOUR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:828:6: ( 'hour' )
            // MacroScope\\MacroScope.g:828:8: 'hour'
            {
            	Match("hour"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "HOUR"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:829:4: ( 'in' )
            // MacroScope\\MacroScope.g:829:6: 'in'
            {
            	Match("in"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "INNER"
    public void mINNER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INNER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:830:7: ( 'inner' )
            // MacroScope\\MacroScope.g:830:9: 'inner'
            {
            	Match("inner"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INNER"

    // $ANTLR start "INSERT"
    public void mINSERT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INSERT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:831:8: ( 'insert' )
            // MacroScope\\MacroScope.g:831:10: 'insert'
            {
            	Match("insert"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INSERT"

    // $ANTLR start "INTERVAL"
    public void mINTERVAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTERVAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:832:10: ( 'interval' )
            // MacroScope\\MacroScope.g:832:12: 'interval'
            {
            	Match("interval"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTERVAL"

    // $ANTLR start "INTO"
    public void mINTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:833:6: ( 'into' )
            // MacroScope\\MacroScope.g:833:8: 'into'
            {
            	Match("into"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTO"

    // $ANTLR start "IS"
    public void mIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:834:4: ( 'is' )
            // MacroScope\\MacroScope.g:834:6: 'is'
            {
            	Match("is"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IS"

    // $ANTLR start "JOIN"
    public void mJOIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = JOIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:835:6: ( 'join' )
            // MacroScope\\MacroScope.g:835:8: 'join'
            {
            	Match("join"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "JOIN"

    // $ANTLR start "LEFT"
    public void mLEFT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:836:6: ( 'left' )
            // MacroScope\\MacroScope.g:836:8: 'left'
            {
            	Match("left"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFT"

    // $ANTLR start "LIKE"
    public void mLIKE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LIKE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:837:6: ( 'like' )
            // MacroScope\\MacroScope.g:837:8: 'like'
            {
            	Match("like"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LIKE"

    // $ANTLR start "MINUTE"
    public void mMINUTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:838:8: ( 'minute' )
            // MacroScope\\MacroScope.g:838:10: 'minute'
            {
            	Match("minute"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUTE"

    // $ANTLR start "MONTH"
    public void mMONTH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MONTH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:839:7: ( 'month' )
            // MacroScope\\MacroScope.g:839:9: 'month'
            {
            	Match("month"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MONTH"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:840:5: ( 'not' )
            // MacroScope\\MacroScope.g:840:7: 'not'
            {
            	Match("not"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "NULL"
    public void mNULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:841:6: ( 'null' )
            // MacroScope\\MacroScope.g:841:8: 'null'
            {
            	Match("null"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NULL"

    // $ANTLR start "ON"
    public void mON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:842:4: ( 'on' )
            // MacroScope\\MacroScope.g:842:6: 'on'
            {
            	Match("on"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ON"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:843:4: ( 'or' )
            // MacroScope\\MacroScope.g:843:6: 'or'
            {
            	Match("or"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "ORDER"
    public void mORDER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ORDER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:844:7: ( 'order' )
            // MacroScope\\MacroScope.g:844:9: 'order'
            {
            	Match("order"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ORDER"

    // $ANTLR start "OUTER"
    public void mOUTER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OUTER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:845:7: ( 'outer' )
            // MacroScope\\MacroScope.g:845:9: 'outer'
            {
            	Match("outer"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OUTER"

    // $ANTLR start "RIGHT"
    public void mRIGHT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:846:7: ( 'right' )
            // MacroScope\\MacroScope.g:846:9: 'right'
            {
            	Match("right"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHT"

    // $ANTLR start "SECOND"
    public void mSECOND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SECOND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:847:8: ( 'second' )
            // MacroScope\\MacroScope.g:847:10: 'second'
            {
            	Match("second"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SECOND"

    // $ANTLR start "SELECT"
    public void mSELECT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SELECT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:848:8: ( 'select' )
            // MacroScope\\MacroScope.g:848:10: 'select'
            {
            	Match("select"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SELECT"

    // $ANTLR start "SET"
    public void mSET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:849:5: ( 'set' )
            // MacroScope\\MacroScope.g:849:7: 'set'
            {
            	Match("set"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SET"

    // $ANTLR start "SOME"
    public void mSOME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:850:6: ( 'some' )
            // MacroScope\\MacroScope.g:850:8: 'some'
            {
            	Match("some"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOME"

    // $ANTLR start "SUBSTRING"
    public void mSUBSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUBSTRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:851:11: ( 'substring' )
            // MacroScope\\MacroScope.g:851:13: 'substring'
            {
            	Match("substring"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUBSTRING"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:852:6: ( 'then' )
            // MacroScope\\MacroScope.g:852:8: 'then'
            {
            	Match("then"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "TIMESTAMP"
    public void mTIMESTAMP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIMESTAMP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:853:10: ( 'timestamp' )
            // MacroScope\\MacroScope.g:853:12: 'timestamp'
            {
            	Match("timestamp"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIMESTAMP"

    // $ANTLR start "TOP"
    public void mTOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:854:5: ( 'top' )
            // MacroScope\\MacroScope.g:854:7: 'top'
            {
            	Match("top"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TOP"

    // $ANTLR start "UNION"
    public void mUNION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:855:7: ( 'union' )
            // MacroScope\\MacroScope.g:855:9: 'union'
            {
            	Match("union"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNION"

    // $ANTLR start "UPDATE"
    public void mUPDATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UPDATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:856:8: ( 'update' )
            // MacroScope\\MacroScope.g:856:10: 'update'
            {
            	Match("update"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UPDATE"

    // $ANTLR start "VALUES"
    public void mVALUES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VALUES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:857:8: ( 'values' )
            // MacroScope\\MacroScope.g:857:10: 'values'
            {
            	Match("values"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VALUES"

    // $ANTLR start "WHEN"
    public void mWHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:858:6: ( 'when' )
            // MacroScope\\MacroScope.g:858:8: 'when'
            {
            	Match("when"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHEN"

    // $ANTLR start "WHERE"
    public void mWHERE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHERE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:859:7: ( 'where' )
            // MacroScope\\MacroScope.g:859:9: 'where'
            {
            	Match("where"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHERE"

    // $ANTLR start "YEAR"
    public void mYEAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = YEAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:860:6: ( 'year' )
            // MacroScope\\MacroScope.g:860:8: 'year'
            {
            	Match("year"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "YEAR"

    // $ANTLR start "DOT_STAR"
    public void mDOT_STAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT_STAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:862:9: ( '.*' )
            // MacroScope\\MacroScope.g:862:11: '.*'
            {
            	Match(".*"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT_STAR"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:863:5: ( '.' )
            // MacroScope\\MacroScope.g:863:7: '.'
            {
            	Match('.'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:864:7: ( ',' )
            // MacroScope\\MacroScope.g:864:9: ','
            {
            	Match(','); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    // $ANTLR start "LPAREN"
    public void mLPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:865:8: ( '(' )
            // MacroScope\\MacroScope.g:865:10: '('
            {
            	Match('('); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LPAREN"

    // $ANTLR start "RPAREN"
    public void mRPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:866:8: ( ')' )
            // MacroScope\\MacroScope.g:866:10: ')'
            {
            	Match(')'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RPAREN"

    // $ANTLR start "ASSIGNEQUAL"
    public void mASSIGNEQUAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNEQUAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:868:13: ( '=' )
            // MacroScope\\MacroScope.g:868:15: '='
            {
            	Match('='); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNEQUAL"

    // $ANTLR start "NOTEQUAL1"
    public void mNOTEQUAL1() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOTEQUAL1;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:869:11: ( '<>' )
            // MacroScope\\MacroScope.g:869:13: '<>'
            {
            	Match("<>"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOTEQUAL1"

    // $ANTLR start "NOTEQUAL2"
    public void mNOTEQUAL2() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOTEQUAL2;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:870:11: ( '!=' )
            // MacroScope\\MacroScope.g:870:13: '!='
            {
            	Match("!="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOTEQUAL2"

    // $ANTLR start "LESSTHANOREQUALTO1"
    public void mLESSTHANOREQUALTO1() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHANOREQUALTO1;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:871:20: ( '<=' )
            // MacroScope\\MacroScope.g:871:22: '<='
            {
            	Match("<="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSTHANOREQUALTO1"

    // $ANTLR start "LESSTHAN"
    public void mLESSTHAN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHAN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:872:10: ( '<' )
            // MacroScope\\MacroScope.g:872:12: '<'
            {
            	Match('<'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSTHAN"

    // $ANTLR start "GREATERTHANOREQUALTO1"
    public void mGREATERTHANOREQUALTO1() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHANOREQUALTO1;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:873:23: ( '>=' )
            // MacroScope\\MacroScope.g:873:25: '>='
            {
            	Match(">="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GREATERTHANOREQUALTO1"

    // $ANTLR start "GREATERTHAN"
    public void mGREATERTHAN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHAN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:874:13: ( '>' )
            // MacroScope\\MacroScope.g:874:15: '>'
            {
            	Match('>'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GREATERTHAN"

    // $ANTLR start "DIVIDE"
    public void mDIVIDE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIVIDE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:876:8: ( '/' )
            // MacroScope\\MacroScope.g:876:10: '/'
            {
            	Match('/'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIVIDE"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:877:6: ( '+' )
            // MacroScope\\MacroScope.g:877:8: '+'
            {
            	Match('+'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "STAR"
    public void mSTAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:878:6: ( '*' )
            // MacroScope\\MacroScope.g:878:8: '*'
            {
            	Match('*'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STAR"

    // $ANTLR start "MOD"
    public void mMOD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MOD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:879:5: ( '%' )
            // MacroScope\\MacroScope.g:879:7: '%'
            {
            	Match('%'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MOD"

    // $ANTLR start "STRCONCAT"
    public void mSTRCONCAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRCONCAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:881:11: ( '||' )
            // MacroScope\\MacroScope.g:881:13: '||'
            {
            	Match("||"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRCONCAT"

    // $ANTLR start "PLACEHOLDER"
    public void mPLACEHOLDER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLACEHOLDER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:883:12: ( '?' )
            // MacroScope\\MacroScope.g:883:14: '?'
            {
            	Match('?'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLACEHOLDER"

    // $ANTLR start "Letter"
    public void mLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:886:8: ( 'a' .. 'z' )
            // MacroScope\\MacroScope.g:886:10: 'a' .. 'z'
            {
            	MatchRange('a','z'); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Letter"

    // $ANTLR start "Digit"
    public void mDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:889:7: ( '0' .. '9' )
            // MacroScope\\MacroScope.g:889:9: '0' .. '9'
            {
            	MatchRange('0','9'); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Digit"

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:892:9: ()
            // MacroScope\\MacroScope.g:892:10: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Integer"

    // $ANTLR start "Real"
    public void mReal() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:895:6: ()
            // MacroScope\\MacroScope.g:895:7: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Real"

    // $ANTLR start "Exponent"
    public void mExponent() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:898:10: ( 'e' ( '+' | '-' )? ( Digit )+ )
            // MacroScope\\MacroScope.g:899:2: 'e' ( '+' | '-' )? ( Digit )+
            {
            	Match('e'); if (state.failed) return ;
            	// MacroScope\\MacroScope.g:899:6: ( '+' | '-' )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == '+' || LA1_0 == '-') )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();
            	        	state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:899:21: ( Digit )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:899:22: Digit
            			    {
            			    	mDigit(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Exponent"

    // $ANTLR start "MAccessDateTime"
    public void mMAccessDateTime() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAccessDateTime;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:902:17: ( '#' Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ' ' Digit Digit ':' Digit Digit ':' Digit Digit '#' )
            // MacroScope\\MacroScope.g:903:2: '#' Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ' ' Digit Digit ':' Digit Digit ':' Digit Digit '#'
            {
            	Match('#'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match('-'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match('-'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match(' '); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match(':'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match(':'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match('#'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAccessDateTime"

    // $ANTLR start "Iso8601DateTime"
    public void mIso8601DateTime() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Iso8601DateTime;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:909:17: ( Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ( 't' | ' ' ) Digit Digit ':' Digit Digit ':' Digit Digit )
            // MacroScope\\MacroScope.g:910:2: Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ( 't' | ' ' ) Digit Digit ':' Digit Digit ':' Digit Digit
            {
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match('-'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match('-'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	if ( input.LA(1) == ' ' || input.LA(1) == 't' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match(':'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	Match(':'); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;
            	mDigit(); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Iso8601DateTime"

    // $ANTLR start "Number"
    public void mNumber() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Number;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:915:8: ( ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent ) | '.' ( ( Digit )+ ( Exponent )? )? | ( Digit )+ | '0x' ( 'a' .. 'f' | Digit )* )
            int alt12 = 4;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:916:2: ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent )
                    {
                    	// MacroScope\\MacroScope.g:916:30: ( Digit )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:916:31: Digit
                    			    {
                    			    	mDigit(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    		            EarlyExitException eee3 =
                    		                new EarlyExitException(3, input);
                    		            throw eee3;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whinging that label 'loop3' has no statements

                    	// MacroScope\\MacroScope.g:916:39: ( '.' ( Digit )* ( Exponent )? | Exponent )
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);

                    	if ( (LA6_0 == '.') )
                    	{
                    	    alt6 = 1;
                    	}
                    	else if ( (LA6_0 == 'e') )
                    	{
                    	    alt6 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	    NoViableAltException nvae_d6s0 =
                    	        new NoViableAltException("", 6, 0, input);

                    	    throw nvae_d6s0;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:916:41: '.' ( Digit )* ( Exponent )?
                    	        {
                    	        	Match('.'); if (state.failed) return ;
                    	        	// MacroScope\\MacroScope.g:916:45: ( Digit )*
                    	        	do 
                    	        	{
                    	        	    int alt4 = 2;
                    	        	    int LA4_0 = input.LA(1);

                    	        	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	        	    {
                    	        	        alt4 = 1;
                    	        	    }


                    	        	    switch (alt4) 
                    	        		{
                    	        			case 1 :
                    	        			    // MacroScope\\MacroScope.g:916:46: Digit
                    	        			    {
                    	        			    	mDigit(); if (state.failed) return ;

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop4;
                    	        	    }
                    	        	} while (true);

                    	        	loop4:
                    	        		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	        	// MacroScope\\MacroScope.g:916:54: ( Exponent )?
                    	        	int alt5 = 2;
                    	        	int LA5_0 = input.LA(1);

                    	        	if ( (LA5_0 == 'e') )
                    	        	{
                    	        	    alt5 = 1;
                    	        	}
                    	        	switch (alt5) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:916:55: Exponent
                    	        	        {
                    	        	        	mExponent(); if (state.failed) return ;

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:916:68: Exponent
                    	        {
                    	        	mExponent(); if (state.failed) return ;

                    	        }
                    	        break;

                    	}

                    	if ( (state.backtracking==0) )
                    	{
                    	   _type = Real; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:917:4: '.' ( ( Digit )+ ( Exponent )? )?
                    {
                    	Match('.'); if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   _type = DOT; 
                    	}
                    	// MacroScope\\MacroScope.g:917:25: ( ( Digit )+ ( Exponent )? )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:917:27: ( Digit )+ ( Exponent )?
                    	        {
                    	        	// MacroScope\\MacroScope.g:917:27: ( Digit )+
                    	        	int cnt7 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt7 = 2;
                    	        	    int LA7_0 = input.LA(1);

                    	        	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
                    	        	    {
                    	        	        alt7 = 1;
                    	        	    }


                    	        	    switch (alt7) 
                    	        		{
                    	        			case 1 :
                    	        			    // MacroScope\\MacroScope.g:917:28: Digit
                    	        			    {
                    	        			    	mDigit(); if (state.failed) return ;

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt7 >= 1 ) goto loop7;
                    	        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        		            EarlyExitException eee7 =
                    	        		                new EarlyExitException(7, input);
                    	        		            throw eee7;
                    	        	    }
                    	        	    cnt7++;
                    	        	} while (true);

                    	        	loop7:
                    	        		;	// Stops C# compiler whinging that label 'loop7' has no statements

                    	        	// MacroScope\\MacroScope.g:917:36: ( Exponent )?
                    	        	int alt8 = 2;
                    	        	int LA8_0 = input.LA(1);

                    	        	if ( (LA8_0 == 'e') )
                    	        	{
                    	        	    alt8 = 1;
                    	        	}
                    	        	switch (alt8) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:917:37: Exponent
                    	        	        {
                    	        	        	mExponent(); if (state.failed) return ;

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   _type = Real; 
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:918:4: ( Digit )+
                    {
                    	// MacroScope\\MacroScope.g:918:4: ( Digit )+
                    	int cnt10 = 0;
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:918:5: Digit
                    			    {
                    			    	mDigit(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt10 >= 1 ) goto loop10;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    		            EarlyExitException eee10 =
                    		                new EarlyExitException(10, input);
                    		            throw eee10;
                    	    }
                    	    cnt10++;
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whinging that label 'loop10' has no statements

                    	if ( (state.backtracking==0) )
                    	{
                    	   _type = Integer; 
                    	}

                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:919:4: '0x' ( 'a' .. 'f' | Digit )*
                    {
                    	Match("0x"); if (state.failed) return ;

                    	// MacroScope\\MacroScope.g:919:9: ( 'a' .. 'f' | Digit )*
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( ((LA11_0 >= '0' && LA11_0 <= '9') || (LA11_0 >= 'a' && LA11_0 <= 'f')) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:
                    			    {
                    			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop11;
                    	    }
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements

                    	if ( (state.backtracking==0) )
                    	{
                    	   _type = HexLiteral; 
                    	}

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Number"

    // $ANTLR start "WordTail"
    public void mWordTail() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:923:10: ( ( Letter | Digit | '_' )* )
            // MacroScope\\MacroScope.g:924:2: ( Letter | Digit | '_' )*
            {
            	// MacroScope\\MacroScope.g:924:2: ( Letter | Digit | '_' )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "WordTail"

    // $ANTLR start "NonQuotedIdentifier"
    public void mNonQuotedIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NonQuotedIdentifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:927:21: ( Letter WordTail )
            // MacroScope\\MacroScope.g:927:23: Letter WordTail
            {
            	mLetter(); if (state.failed) return ;
            	mWordTail(); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NonQuotedIdentifier"

    // $ANTLR start "QuotedIdentifier"
    public void mQuotedIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QuotedIdentifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:929:18: ( '[' (~ ']' )* ']' ( ']' (~ ']' )* ']' )* | '\"' (~ '\"' )* '\"' ( '\"' (~ '\"' )* '\"' )* | '`' (~ '`' )* '`' )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case '[':
            	{
                alt21 = 1;
                }
                break;
            case '\"':
            	{
                alt21 = 2;
                }
                break;
            case '`':
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:930:2: '[' (~ ']' )* ']' ( ']' (~ ']' )* ']' )*
                    {
                    	Match('['); if (state.failed) return ;
                    	// MacroScope\\MacroScope.g:930:6: (~ ']' )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\\') || (LA14_0 >= '^' && LA14_0 <= '\uFFFF')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:930:7: ~ ']'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	Match(']'); if (state.failed) return ;
                    	// MacroScope\\MacroScope.g:930:18: ( ']' (~ ']' )* ']' )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( (LA16_0 == ']') )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:930:19: ']' (~ ']' )* ']'
                    			    {
                    			    	Match(']'); if (state.failed) return ;
                    			    	// MacroScope\\MacroScope.g:930:23: (~ ']' )*
                    			    	do 
                    			    	{
                    			    	    int alt15 = 2;
                    			    	    int LA15_0 = input.LA(1);

                    			    	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\\') || (LA15_0 >= '^' && LA15_0 <= '\uFFFF')) )
                    			    	    {
                    			    	        alt15 = 1;
                    			    	    }


                    			    	    switch (alt15) 
                    			    		{
                    			    			case 1 :
                    			    			    // MacroScope\\MacroScope.g:930:24: ~ ']'
                    			    			    {
                    			    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFF') ) 
                    			    			    	{
                    			    			    	    input.Consume();
                    			    			    	state.failed = false;
                    			    			    	}
                    			    			    	else 
                    			    			    	{
                    			    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    			    	    Recover(mse);
                    			    			    	    throw mse;}


                    			    			    }
                    			    			    break;

                    			    			default:
                    			    			    goto loop15;
                    			    	    }
                    			    	} while (true);

                    			    	loop15:
                    			    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    			    	Match(']'); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements


                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:931:4: '\"' (~ '\"' )* '\"' ( '\"' (~ '\"' )* '\"' )*
                    {
                    	Match('\"'); if (state.failed) return ;
                    	// MacroScope\\MacroScope.g:931:8: (~ '\"' )*
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( ((LA17_0 >= '\u0000' && LA17_0 <= '!') || (LA17_0 >= '#' && LA17_0 <= '\uFFFF')) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:931:9: ~ '\"'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop17;
                    	    }
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

                    	Match('\"'); if (state.failed) return ;
                    	// MacroScope\\MacroScope.g:931:20: ( '\"' (~ '\"' )* '\"' )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == '\"') )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:931:21: '\"' (~ '\"' )* '\"'
                    			    {
                    			    	Match('\"'); if (state.failed) return ;
                    			    	// MacroScope\\MacroScope.g:931:25: (~ '\"' )*
                    			    	do 
                    			    	{
                    			    	    int alt18 = 2;
                    			    	    int LA18_0 = input.LA(1);

                    			    	    if ( ((LA18_0 >= '\u0000' && LA18_0 <= '!') || (LA18_0 >= '#' && LA18_0 <= '\uFFFF')) )
                    			    	    {
                    			    	        alt18 = 1;
                    			    	    }


                    			    	    switch (alt18) 
                    			    		{
                    			    			case 1 :
                    			    			    // MacroScope\\MacroScope.g:931:26: ~ '\"'
                    			    			    {
                    			    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
                    			    			    	{
                    			    			    	    input.Consume();
                    			    			    	state.failed = false;
                    			    			    	}
                    			    			    	else 
                    			    			    	{
                    			    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    			    	    Recover(mse);
                    			    			    	    throw mse;}


                    			    			    }
                    			    			    break;

                    			    			default:
                    			    			    goto loop18;
                    			    	    }
                    			    	} while (true);

                    			    	loop18:
                    			    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    			    	Match('\"'); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements


                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:932:4: '`' (~ '`' )* '`'
                    {
                    	Match('`'); if (state.failed) return ;
                    	// MacroScope\\MacroScope.g:932:8: (~ '`' )*
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( ((LA20_0 >= '\u0000' && LA20_0 <= '_') || (LA20_0 >= 'a' && LA20_0 <= '\uFFFF')) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:932:9: ~ '`'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '_') || (input.LA(1) >= 'a' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop20;
                    	    }
                    	} while (true);

                    	loop20:
                    		;	// Stops C# compiler whining that label 'loop20' has no statements

                    	Match('`'); if (state.failed) return ;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QuotedIdentifier"

    // $ANTLR start "Variable"
    public void mVariable() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Variable;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:942:10: ( ( '@' | ':' ) Letter WordTail )
            // MacroScope\\MacroScope.g:943:2: ( '@' | ':' ) Letter WordTail
            {
            	if ( input.LA(1) == ':' || input.LA(1) == '@' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	mLetter(); if (state.failed) return ;
            	mWordTail(); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Variable"

    // $ANTLR start "AsciiStringRun"
    public void mAsciiStringRun() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:947:16: ( ( '\\t' | ' ' .. '&' | '(' .. '~' )+ )
            // MacroScope\\MacroScope.g:949:2: ( '\\t' | ' ' .. '&' | '(' .. '~' )+
            {
            	// MacroScope\\MacroScope.g:949:2: ( '\\t' | ' ' .. '&' | '(' .. '~' )+
            	int cnt22 = 0;
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == '\t' || (LA22_0 >= ' ' && LA22_0 <= '&') || (LA22_0 >= '(' && LA22_0 <= '~')) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( input.LA(1) == '\t' || (input.LA(1) >= ' ' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '~') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt22 >= 1 ) goto loop22;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee22 =
            		                new EarlyExitException(22, input);
            		            throw eee22;
            	    }
            	    cnt22++;
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whinging that label 'loop22' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "AsciiStringRun"

    // $ANTLR start "AsciiStringLiteral"
    public void mAsciiStringLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AsciiStringLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken s = null;

            // MacroScope\\MacroScope.g:952:20: ( '\\'' (s= AsciiStringRun )? '\\'' ( '\\'' (s= AsciiStringRun )? '\\'' )* )
            // MacroScope\\MacroScope.g:953:2: '\\'' (s= AsciiStringRun )? '\\'' ( '\\'' (s= AsciiStringRun )? '\\'' )*
            {
            	Match('\''); if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   Text = ""; 
            	}
            	// MacroScope\\MacroScope.g:954:2: (s= AsciiStringRun )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == '\t' || (LA23_0 >= ' ' && LA23_0 <= '&') || (LA23_0 >= '(' && LA23_0 <= '~')) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:954:4: s= AsciiStringRun
            	        {
            	        	int sStart1235 = CharIndex;
            	        	mAsciiStringRun(); if (state.failed) return ;
            	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1235, CharIndex-1);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   Text = ((s != null) ? s.Text : null); 
            	        	}

            	        }
            	        break;

            	}

            	Match('\''); if (state.failed) return ;
            	// MacroScope\\MacroScope.g:955:2: ( '\\'' (s= AsciiStringRun )? '\\'' )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == '\'') )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:955:4: '\\'' (s= AsciiStringRun )? '\\''
            			    {
            			    	Match('\''); if (state.failed) return ;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			Text = Text + "\'";
            			    	  		
            			    	}
            			    	// MacroScope\\MacroScope.g:957:5: (s= AsciiStringRun )?
            			    	int alt24 = 2;
            			    	int LA24_0 = input.LA(1);

            			    	if ( (LA24_0 == '\t' || (LA24_0 >= ' ' && LA24_0 <= '&') || (LA24_0 >= '(' && LA24_0 <= '~')) )
            			    	{
            			    	    alt24 = 1;
            			    	}
            			    	switch (alt24) 
            			    	{
            			    	    case 1 :
            			    	        // MacroScope\\MacroScope.g:957:7: s= AsciiStringRun
            			    	        {
            			    	        	int sStart1257 = CharIndex;
            			    	        	mAsciiStringRun(); if (state.failed) return ;
            			    	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1257, CharIndex-1);
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   Text = Text + ((s != null) ? s.Text : null); 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	Match('\''); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AsciiStringLiteral"

    // $ANTLR start "UnicodeStringRun"
    public void mUnicodeStringRun() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:962:18: ( (~ '\\'' )+ )
            // MacroScope\\MacroScope.g:963:2: (~ '\\'' )+
            {
            	// MacroScope\\MacroScope.g:963:2: (~ '\\'' )+
            	int cnt26 = 0;
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= '\u0000' && LA26_0 <= '&') || (LA26_0 >= '(' && LA26_0 <= '\uFFFF')) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:963:3: ~ '\\''
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt26 >= 1 ) goto loop26;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee26 =
            		                new EarlyExitException(26, input);
            		            throw eee26;
            	    }
            	    cnt26++;
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whinging that label 'loop26' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeStringRun"

    // $ANTLR start "UnicodeStringLiteral"
    public void mUnicodeStringLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UnicodeStringLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken s = null;

            // MacroScope\\MacroScope.g:966:22: ( 'n' '\\'' (s= UnicodeStringRun )? '\\'' ( '\\'' (s= UnicodeStringRun )? '\\'' )* )
            // MacroScope\\MacroScope.g:967:2: 'n' '\\'' (s= UnicodeStringRun )? '\\'' ( '\\'' (s= UnicodeStringRun )? '\\'' )*
            {
            	Match('n'); if (state.failed) return ;
            	Match('\''); if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   Text = ""; 
            	}
            	// MacroScope\\MacroScope.g:968:2: (s= UnicodeStringRun )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= '\u0000' && LA27_0 <= '&') || (LA27_0 >= '(' && LA27_0 <= '\uFFFF')) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:968:4: s= UnicodeStringRun
            	        {
            	        	int sStart1313 = CharIndex;
            	        	mUnicodeStringRun(); if (state.failed) return ;
            	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1313, CharIndex-1);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   Text = ((s != null) ? s.Text : null); 
            	        	}

            	        }
            	        break;

            	}

            	Match('\''); if (state.failed) return ;
            	// MacroScope\\MacroScope.g:969:2: ( '\\'' (s= UnicodeStringRun )? '\\'' )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == '\'') )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:969:4: '\\'' (s= UnicodeStringRun )? '\\''
            			    {
            			    	Match('\''); if (state.failed) return ;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			Text = Text + "\'";
            			    	  		
            			    	}
            			    	// MacroScope\\MacroScope.g:971:5: (s= UnicodeStringRun )?
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);

            			    	if ( ((LA28_0 >= '\u0000' && LA28_0 <= '&') || (LA28_0 >= '(' && LA28_0 <= '\uFFFF')) )
            			    	{
            			    	    alt28 = 1;
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // MacroScope\\MacroScope.g:971:7: s= UnicodeStringRun
            			    	        {
            			    	        	int sStart1335 = CharIndex;
            			    	        	mUnicodeStringRun(); if (state.failed) return ;
            			    	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1335, CharIndex-1);
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   Text = Text + ((s != null) ? s.Text : null); 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	Match('\''); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeStringLiteral"

    // $ANTLR start "HexLiteral"
    public void mHexLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            // MacroScope\\MacroScope.g:976:12: ()
            // MacroScope\\MacroScope.g:978:2: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexLiteral"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:980:7: ( '-' )
            // MacroScope\\MacroScope.g:980:9: '-'
            {
            	Match('-'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:981:7: ( ':' )
            // MacroScope\\MacroScope.g:981:9: ':'
            {
            	Match(':'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "Whitespace"
    public void mWhitespace() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Whitespace;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MacroScope\\MacroScope.g:983:12: ( ( '\\t' | ' ' | '\\r' | '\\n' )+ )
            // MacroScope\\MacroScope.g:983:14: ( '\\t' | ' ' | '\\r' | '\\n' )+
            {
            	// MacroScope\\MacroScope.g:983:14: ( '\\t' | ' ' | '\\r' | '\\n' )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= '\t' && LA30_0 <= '\n') || LA30_0 == '\r' || LA30_0 == ' ') )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt30 >= 1 ) goto loop30;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee30 =
            		                new EarlyExitException(30, input);
            		            throw eee30;
            	    }
            	    cnt30++;
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whinging that label 'loop30' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   _channel = HIDDEN; 
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Whitespace"

    override public void mTokens() // throws RecognitionException 
    {
        // MacroScope\\MacroScope.g:1:8: ( ALL | AND | ANY | AS | ASC | BETWEEN | BY | CASE | CAST | CROSS | DAY | DEFAULT | DELETE | DESC | DISTINCT | ELSE | END | ESCAPE | EXISTS | EXTRACT | FOR | FROM | FULL | GROUP | HAVING | HOUR | IN | INNER | INSERT | INTERVAL | INTO | IS | JOIN | LEFT | LIKE | MINUTE | MONTH | NOT | NULL | ON | OR | ORDER | OUTER | RIGHT | SECOND | SELECT | SET | SOME | SUBSTRING | THEN | TIMESTAMP | TOP | UNION | UPDATE | VALUES | WHEN | WHERE | YEAR | DOT_STAR | DOT | COMMA | LPAREN | RPAREN | ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN | DIVIDE | PLUS | STAR | MOD | STRCONCAT | PLACEHOLDER | MAccessDateTime | Iso8601DateTime | Number | NonQuotedIdentifier | QuotedIdentifier | Variable | AsciiStringLiteral | UnicodeStringLiteral | MINUS | COLON | Whitespace )
        int alt31 = 87;
        alt31 = dfa31.Predict(input);
        switch (alt31) 
        {
            case 1 :
                // MacroScope\\MacroScope.g:1:10: ALL
                {
                	mALL(); if (state.failed) return ;

                }
                break;
            case 2 :
                // MacroScope\\MacroScope.g:1:14: AND
                {
                	mAND(); if (state.failed) return ;

                }
                break;
            case 3 :
                // MacroScope\\MacroScope.g:1:18: ANY
                {
                	mANY(); if (state.failed) return ;

                }
                break;
            case 4 :
                // MacroScope\\MacroScope.g:1:22: AS
                {
                	mAS(); if (state.failed) return ;

                }
                break;
            case 5 :
                // MacroScope\\MacroScope.g:1:25: ASC
                {
                	mASC(); if (state.failed) return ;

                }
                break;
            case 6 :
                // MacroScope\\MacroScope.g:1:29: BETWEEN
                {
                	mBETWEEN(); if (state.failed) return ;

                }
                break;
            case 7 :
                // MacroScope\\MacroScope.g:1:37: BY
                {
                	mBY(); if (state.failed) return ;

                }
                break;
            case 8 :
                // MacroScope\\MacroScope.g:1:40: CASE
                {
                	mCASE(); if (state.failed) return ;

                }
                break;
            case 9 :
                // MacroScope\\MacroScope.g:1:45: CAST
                {
                	mCAST(); if (state.failed) return ;

                }
                break;
            case 10 :
                // MacroScope\\MacroScope.g:1:50: CROSS
                {
                	mCROSS(); if (state.failed) return ;

                }
                break;
            case 11 :
                // MacroScope\\MacroScope.g:1:56: DAY
                {
                	mDAY(); if (state.failed) return ;

                }
                break;
            case 12 :
                // MacroScope\\MacroScope.g:1:60: DEFAULT
                {
                	mDEFAULT(); if (state.failed) return ;

                }
                break;
            case 13 :
                // MacroScope\\MacroScope.g:1:68: DELETE
                {
                	mDELETE(); if (state.failed) return ;

                }
                break;
            case 14 :
                // MacroScope\\MacroScope.g:1:75: DESC
                {
                	mDESC(); if (state.failed) return ;

                }
                break;
            case 15 :
                // MacroScope\\MacroScope.g:1:80: DISTINCT
                {
                	mDISTINCT(); if (state.failed) return ;

                }
                break;
            case 16 :
                // MacroScope\\MacroScope.g:1:89: ELSE
                {
                	mELSE(); if (state.failed) return ;

                }
                break;
            case 17 :
                // MacroScope\\MacroScope.g:1:94: END
                {
                	mEND(); if (state.failed) return ;

                }
                break;
            case 18 :
                // MacroScope\\MacroScope.g:1:98: ESCAPE
                {
                	mESCAPE(); if (state.failed) return ;

                }
                break;
            case 19 :
                // MacroScope\\MacroScope.g:1:105: EXISTS
                {
                	mEXISTS(); if (state.failed) return ;

                }
                break;
            case 20 :
                // MacroScope\\MacroScope.g:1:112: EXTRACT
                {
                	mEXTRACT(); if (state.failed) return ;

                }
                break;
            case 21 :
                // MacroScope\\MacroScope.g:1:120: FOR
                {
                	mFOR(); if (state.failed) return ;

                }
                break;
            case 22 :
                // MacroScope\\MacroScope.g:1:124: FROM
                {
                	mFROM(); if (state.failed) return ;

                }
                break;
            case 23 :
                // MacroScope\\MacroScope.g:1:129: FULL
                {
                	mFULL(); if (state.failed) return ;

                }
                break;
            case 24 :
                // MacroScope\\MacroScope.g:1:134: GROUP
                {
                	mGROUP(); if (state.failed) return ;

                }
                break;
            case 25 :
                // MacroScope\\MacroScope.g:1:140: HAVING
                {
                	mHAVING(); if (state.failed) return ;

                }
                break;
            case 26 :
                // MacroScope\\MacroScope.g:1:147: HOUR
                {
                	mHOUR(); if (state.failed) return ;

                }
                break;
            case 27 :
                // MacroScope\\MacroScope.g:1:152: IN
                {
                	mIN(); if (state.failed) return ;

                }
                break;
            case 28 :
                // MacroScope\\MacroScope.g:1:155: INNER
                {
                	mINNER(); if (state.failed) return ;

                }
                break;
            case 29 :
                // MacroScope\\MacroScope.g:1:161: INSERT
                {
                	mINSERT(); if (state.failed) return ;

                }
                break;
            case 30 :
                // MacroScope\\MacroScope.g:1:168: INTERVAL
                {
                	mINTERVAL(); if (state.failed) return ;

                }
                break;
            case 31 :
                // MacroScope\\MacroScope.g:1:177: INTO
                {
                	mINTO(); if (state.failed) return ;

                }
                break;
            case 32 :
                // MacroScope\\MacroScope.g:1:182: IS
                {
                	mIS(); if (state.failed) return ;

                }
                break;
            case 33 :
                // MacroScope\\MacroScope.g:1:185: JOIN
                {
                	mJOIN(); if (state.failed) return ;

                }
                break;
            case 34 :
                // MacroScope\\MacroScope.g:1:190: LEFT
                {
                	mLEFT(); if (state.failed) return ;

                }
                break;
            case 35 :
                // MacroScope\\MacroScope.g:1:195: LIKE
                {
                	mLIKE(); if (state.failed) return ;

                }
                break;
            case 36 :
                // MacroScope\\MacroScope.g:1:200: MINUTE
                {
                	mMINUTE(); if (state.failed) return ;

                }
                break;
            case 37 :
                // MacroScope\\MacroScope.g:1:207: MONTH
                {
                	mMONTH(); if (state.failed) return ;

                }
                break;
            case 38 :
                // MacroScope\\MacroScope.g:1:213: NOT
                {
                	mNOT(); if (state.failed) return ;

                }
                break;
            case 39 :
                // MacroScope\\MacroScope.g:1:217: NULL
                {
                	mNULL(); if (state.failed) return ;

                }
                break;
            case 40 :
                // MacroScope\\MacroScope.g:1:222: ON
                {
                	mON(); if (state.failed) return ;

                }
                break;
            case 41 :
                // MacroScope\\MacroScope.g:1:225: OR
                {
                	mOR(); if (state.failed) return ;

                }
                break;
            case 42 :
                // MacroScope\\MacroScope.g:1:228: ORDER
                {
                	mORDER(); if (state.failed) return ;

                }
                break;
            case 43 :
                // MacroScope\\MacroScope.g:1:234: OUTER
                {
                	mOUTER(); if (state.failed) return ;

                }
                break;
            case 44 :
                // MacroScope\\MacroScope.g:1:240: RIGHT
                {
                	mRIGHT(); if (state.failed) return ;

                }
                break;
            case 45 :
                // MacroScope\\MacroScope.g:1:246: SECOND
                {
                	mSECOND(); if (state.failed) return ;

                }
                break;
            case 46 :
                // MacroScope\\MacroScope.g:1:253: SELECT
                {
                	mSELECT(); if (state.failed) return ;

                }
                break;
            case 47 :
                // MacroScope\\MacroScope.g:1:260: SET
                {
                	mSET(); if (state.failed) return ;

                }
                break;
            case 48 :
                // MacroScope\\MacroScope.g:1:264: SOME
                {
                	mSOME(); if (state.failed) return ;

                }
                break;
            case 49 :
                // MacroScope\\MacroScope.g:1:269: SUBSTRING
                {
                	mSUBSTRING(); if (state.failed) return ;

                }
                break;
            case 50 :
                // MacroScope\\MacroScope.g:1:279: THEN
                {
                	mTHEN(); if (state.failed) return ;

                }
                break;
            case 51 :
                // MacroScope\\MacroScope.g:1:284: TIMESTAMP
                {
                	mTIMESTAMP(); if (state.failed) return ;

                }
                break;
            case 52 :
                // MacroScope\\MacroScope.g:1:294: TOP
                {
                	mTOP(); if (state.failed) return ;

                }
                break;
            case 53 :
                // MacroScope\\MacroScope.g:1:298: UNION
                {
                	mUNION(); if (state.failed) return ;

                }
                break;
            case 54 :
                // MacroScope\\MacroScope.g:1:304: UPDATE
                {
                	mUPDATE(); if (state.failed) return ;

                }
                break;
            case 55 :
                // MacroScope\\MacroScope.g:1:311: VALUES
                {
                	mVALUES(); if (state.failed) return ;

                }
                break;
            case 56 :
                // MacroScope\\MacroScope.g:1:318: WHEN
                {
                	mWHEN(); if (state.failed) return ;

                }
                break;
            case 57 :
                // MacroScope\\MacroScope.g:1:323: WHERE
                {
                	mWHERE(); if (state.failed) return ;

                }
                break;
            case 58 :
                // MacroScope\\MacroScope.g:1:329: YEAR
                {
                	mYEAR(); if (state.failed) return ;

                }
                break;
            case 59 :
                // MacroScope\\MacroScope.g:1:334: DOT_STAR
                {
                	mDOT_STAR(); if (state.failed) return ;

                }
                break;
            case 60 :
                // MacroScope\\MacroScope.g:1:343: DOT
                {
                	mDOT(); if (state.failed) return ;

                }
                break;
            case 61 :
                // MacroScope\\MacroScope.g:1:347: COMMA
                {
                	mCOMMA(); if (state.failed) return ;

                }
                break;
            case 62 :
                // MacroScope\\MacroScope.g:1:353: LPAREN
                {
                	mLPAREN(); if (state.failed) return ;

                }
                break;
            case 63 :
                // MacroScope\\MacroScope.g:1:360: RPAREN
                {
                	mRPAREN(); if (state.failed) return ;

                }
                break;
            case 64 :
                // MacroScope\\MacroScope.g:1:367: ASSIGNEQUAL
                {
                	mASSIGNEQUAL(); if (state.failed) return ;

                }
                break;
            case 65 :
                // MacroScope\\MacroScope.g:1:379: NOTEQUAL1
                {
                	mNOTEQUAL1(); if (state.failed) return ;

                }
                break;
            case 66 :
                // MacroScope\\MacroScope.g:1:389: NOTEQUAL2
                {
                	mNOTEQUAL2(); if (state.failed) return ;

                }
                break;
            case 67 :
                // MacroScope\\MacroScope.g:1:399: LESSTHANOREQUALTO1
                {
                	mLESSTHANOREQUALTO1(); if (state.failed) return ;

                }
                break;
            case 68 :
                // MacroScope\\MacroScope.g:1:418: LESSTHAN
                {
                	mLESSTHAN(); if (state.failed) return ;

                }
                break;
            case 69 :
                // MacroScope\\MacroScope.g:1:427: GREATERTHANOREQUALTO1
                {
                	mGREATERTHANOREQUALTO1(); if (state.failed) return ;

                }
                break;
            case 70 :
                // MacroScope\\MacroScope.g:1:449: GREATERTHAN
                {
                	mGREATERTHAN(); if (state.failed) return ;

                }
                break;
            case 71 :
                // MacroScope\\MacroScope.g:1:461: DIVIDE
                {
                	mDIVIDE(); if (state.failed) return ;

                }
                break;
            case 72 :
                // MacroScope\\MacroScope.g:1:468: PLUS
                {
                	mPLUS(); if (state.failed) return ;

                }
                break;
            case 73 :
                // MacroScope\\MacroScope.g:1:473: STAR
                {
                	mSTAR(); if (state.failed) return ;

                }
                break;
            case 74 :
                // MacroScope\\MacroScope.g:1:478: MOD
                {
                	mMOD(); if (state.failed) return ;

                }
                break;
            case 75 :
                // MacroScope\\MacroScope.g:1:482: STRCONCAT
                {
                	mSTRCONCAT(); if (state.failed) return ;

                }
                break;
            case 76 :
                // MacroScope\\MacroScope.g:1:492: PLACEHOLDER
                {
                	mPLACEHOLDER(); if (state.failed) return ;

                }
                break;
            case 77 :
                // MacroScope\\MacroScope.g:1:504: MAccessDateTime
                {
                	mMAccessDateTime(); if (state.failed) return ;

                }
                break;
            case 78 :
                // MacroScope\\MacroScope.g:1:520: Iso8601DateTime
                {
                	mIso8601DateTime(); if (state.failed) return ;

                }
                break;
            case 79 :
                // MacroScope\\MacroScope.g:1:536: Number
                {
                	mNumber(); if (state.failed) return ;

                }
                break;
            case 80 :
                // MacroScope\\MacroScope.g:1:543: NonQuotedIdentifier
                {
                	mNonQuotedIdentifier(); if (state.failed) return ;

                }
                break;
            case 81 :
                // MacroScope\\MacroScope.g:1:563: QuotedIdentifier
                {
                	mQuotedIdentifier(); if (state.failed) return ;

                }
                break;
            case 82 :
                // MacroScope\\MacroScope.g:1:580: Variable
                {
                	mVariable(); if (state.failed) return ;

                }
                break;
            case 83 :
                // MacroScope\\MacroScope.g:1:589: AsciiStringLiteral
                {
                	mAsciiStringLiteral(); if (state.failed) return ;

                }
                break;
            case 84 :
                // MacroScope\\MacroScope.g:1:608: UnicodeStringLiteral
                {
                	mUnicodeStringLiteral(); if (state.failed) return ;

                }
                break;
            case 85 :
                // MacroScope\\MacroScope.g:1:629: MINUS
                {
                	mMINUS(); if (state.failed) return ;

                }
                break;
            case 86 :
                // MacroScope\\MacroScope.g:1:635: COLON
                {
                	mCOLON(); if (state.failed) return ;

                }
                break;
            case 87 :
                // MacroScope\\MacroScope.g:1:641: Whitespace
                {
                	mWhitespace(); if (state.failed) return ;

                }
                break;

        }

    }

    // $ANTLR start "synpred1_MacroScope"
    public void synpred1_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:916:2: ( ( Digit )+ ( '.' | 'e' ) )
        // MacroScope\\MacroScope.g:916:4: ( Digit )+ ( '.' | 'e' )
        {
        	// MacroScope\\MacroScope.g:916:4: ( Digit )+
        	int cnt32 = 0;
        	do 
        	{
        	    int alt32 = 2;
        	    int LA32_0 = input.LA(1);

        	    if ( ((LA32_0 >= '0' && LA32_0 <= '9')) )
        	    {
        	        alt32 = 1;
        	    }


        	    switch (alt32) 
        		{
        			case 1 :
        			    // MacroScope\\MacroScope.g:916:5: Digit
        			    {
        			    	mDigit(); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt32 >= 1 ) goto loop32;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee32 =
        		                new EarlyExitException(32, input);
        		            throw eee32;
        	    }
        	    cnt32++;
        	} while (true);

        	loop32:
        		;	// Stops C# compiler whinging that label 'loop32' has no statements

        	if ( input.LA(1) == '.' || input.LA(1) == 'e' ) 
        	{
        	    input.Consume();
        	state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    Recover(mse);
        	    throw mse;}


        }
    }
    // $ANTLR end "synpred1_MacroScope"

   	public bool synpred1_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


    protected DFA12 dfa12;
    protected DFA31 dfa31;
	private void InitializeCyclicDFAs()
	{
	    this.dfa12 = new DFA12(this);
	    this.dfa31 = new DFA31(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);

	}

    const string DFA12_eotS =
        "\x01\uffff\x01\x05\x01\uffff\x01\x05\x04\uffff";
    const string DFA12_eofS =
        "\x08\uffff";
    const string DFA12_minS =
        "\x02\x2e\x01\uffff\x01\x2e\x04\uffff";
    const string DFA12_maxS =
        "\x01\x39\x01\x78\x01\uffff\x01\x65\x04\uffff";
    const string DFA12_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x04\x01\x03\x02\x01";
    const string DFA12_specialS =
        "\x01\uffff\x01\x00\x01\uffff\x01\x01\x04\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x02\x01\uffff\x01\x01\x09\x03",
            "\x01\x06\x01\uffff\x0a\x03\x2b\uffff\x01\x07\x12\uffff\x01"+
            "\x04",
            "",
            "\x01\x06\x01\uffff\x0a\x03\x2b\uffff\x01\x07",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "915:1: Number : ( ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent ) | '.' ( ( Digit )+ ( Exponent )? )? | ( Digit )+ | '0x' ( 'a' .. 'f' | Digit )* );"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_1 = input.LA(1);

                   	 
                   	int index12_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA12_1 == 'x') ) { s = 4; }

                   	else if ( (LA12_1 == '.') && (synpred1_MacroScope()) ) { s = 6; }

                   	else if ( (LA12_1 == 'e') && (synpred1_MacroScope()) ) { s = 7; }

                   	else if ( ((LA12_1 >= '0' && LA12_1 <= '9')) ) { s = 3; }

                   	else s = 5;

                   	 
                   	input.Seek(index12_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_3 = input.LA(1);

                   	 
                   	int index12_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA12_3 == '.') && (synpred1_MacroScope()) ) { s = 6; }

                   	else if ( (LA12_3 == 'e') && (synpred1_MacroScope()) ) { s = 7; }

                   	else if ( ((LA12_3 >= '0' && LA12_3 <= '9')) ) { s = 3; }

                   	else s = 5;

                   	 
                   	input.Seek(index12_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA31_eotS =
        "\x01\uffff\x15\x27\x01\x5c\x04\uffff\x01\x60\x01\uffff\x01\x62"+
        "\x07\uffff\x02\x5d\x02\uffff\x01\x64\x04\uffff\x02\x27\x01\x69\x01"+
        "\x27\x01\x6b\x0f\x27\x01\u0081\x01\u0082\x07\x27\x01\uffff\x01\u008a"+
        "\x01\u008c\x0d\x27\x08\uffff\x01\x5d\x01\uffff\x01\u009d\x01\u009e"+
        "\x01\u009f\x01\u00a0\x01\uffff\x01\x27\x01\uffff\x02\x27\x01\u00a5"+
        "\x05\x27\x01\u00ab\x03\x27\x01\u00af\x08\x27\x02\uffff\x05\x27\x01"+
        "\u00be\x01\x27\x01\uffff\x01\x27\x01\uffff\x04\x27\x01\u00c5\x04"+
        "\x27\x01\u00ca\x05\x27\x01\x5d\x04\uffff\x01\x27\x01\u00d3\x01\u00d4"+
        "\x01\x27\x01\uffff\x02\x27\x01\u00d8\x01\x27\x01\u00da\x01\uffff"+
        "\x03\x27\x01\uffff\x01\u00de\x01\u00df\x02\x27\x01\u00e2\x03\x27"+
        "\x01\u00e6\x01\u00e7\x01\u00e8\x01\u00e9\x02\x27\x01\uffff\x01\u00ec"+
        "\x05\x27\x01\uffff\x01\u00f2\x01\x27\x01\u00f4\x01\x27\x01\uffff"+
        "\x03\x27\x01\u00f9\x01\x27\x01\u00fb\x01\x5d\x01\x27\x02\uffff\x01"+
        "\u00fe\x02\x27\x01\uffff\x01\x27\x01\uffff\x03\x27\x02\uffff\x01"+
        "\u0105\x01\x27\x01\uffff\x01\u0107\x02\x27\x04\uffff\x01\x27\x01"+
        "\u010b\x01\uffff\x01\u010c\x01\u010d\x01\u010e\x02\x27\x01\uffff"+
        "\x01\x27\x01\uffff\x01\x27\x01\u0113\x02\x27\x01\uffff\x01\u0116"+
        "\x02\uffff\x01\x27\x01\uffff\x01\x27\x01\u0119\x01\x27\x01\u011b"+
        "\x01\u011c\x01\x27\x01\uffff\x01\u011e\x01\uffff\x01\u011f\x01\x27"+
        "\x01\u0121\x04\uffff\x01\u0122\x01\u0123\x02\x27\x01\uffff\x01\u0126"+
        "\x01\u0127\x01\uffff\x01\u0128\x01\u0129\x01\uffff\x01\x27\x02\uffff"+
        "\x01\u012b\x02\uffff\x01\x27\x03\uffff\x02\x27\x04\uffff\x01\u012f"+
        "\x01\uffff\x01\u0130\x02\x27\x02\uffff\x01\u0133\x01\u0134\x02\uffff";
    const string DFA31_eofS =
        "\u0135\uffff";
    const string DFA31_minS =
        "\x01\x09\x01\x6c\x01\x65\x02\x61\x01\x6c\x01\x6f\x01\x72\x01\x61"+
        "\x01\x6e\x01\x6f\x01\x65\x01\x69\x01\x27\x01\x6e\x01\x69\x01\x65"+
        "\x01\x68\x01\x6e\x01\x61\x01\x68\x01\x65\x01\x2a\x04\uffff\x01\x3d"+
        "\x01\uffff\x01\x3d\x07\uffff\x02\x30\x02\uffff\x01\x61\x04\uffff"+
        "\x01\x6c\x01\x64\x01\x30\x01\x74\x01\x30\x01\x73\x01\x6f\x01\x79"+
        "\x01\x66\x02\x73\x01\x64\x01\x63\x01\x69\x01\x72\x01\x6f\x01\x6c"+
        "\x01\x6f\x01\x76\x01\x75\x02\x30\x01\x69\x01\x66\x01\x6b\x02\x6e"+
        "\x01\x74\x01\x6c\x01\uffff\x02\x30\x01\x74\x01\x67\x01\x63\x01\x6d"+
        "\x01\x62\x01\x65\x01\x6d\x01\x70\x01\x69\x01\x64\x01\x6c\x01\x65"+
        "\x01\x61\x08\uffff\x01\x30\x01\uffff\x04\x30\x01\uffff\x01\x77\x01"+
        "\uffff\x01\x65\x01\x73\x01\x30\x01\x61\x01\x65\x01\x63\x01\x74\x01"+
        "\x65\x01\x30\x01\x61\x01\x73\x01\x72\x01\x30\x01\x6d\x01\x6c\x01"+
        "\x75\x01\x69\x01\x72\x03\x65\x02\uffff\x01\x6e\x01\x74\x01\x65\x01"+
        "\x75\x01\x74\x01\x30\x01\x6c\x01\uffff\x01\x65\x01\uffff\x01\x65"+
        "\x01\x68\x01\x6f\x01\x65\x01\x30\x01\x65\x01\x73\x01\x6e\x01\x65"+
        "\x01\x30\x01\x6f\x01\x61\x01\x75\x01\x6e\x01\x72\x01\x30\x04\uffff"+
        "\x01\x65\x02\x30\x01\x73\x01\uffff\x01\x75\x01\x74\x01\x30\x01\x69"+
        "\x01\x30\x01\uffff\x01\x70\x01\x74\x01\x61\x01\uffff\x02\x30\x01"+
        "\x70\x01\x6e\x01\x30\x03\x72\x04\x30\x01\x74\x01\x68\x01\uffff\x01"+
        "\x30\x02\x72\x01\x74\x01\x6e\x01\x63\x01\uffff\x01\x30\x01\x74\x01"+
        "\x30\x01\x73\x01\uffff\x01\x6e\x01\x74\x01\x65\x01\x30\x01\x65\x01"+
        "\x30\x01\x2d\x01\x65\x02\uffff\x01\x30\x01\x6c\x01\x65\x01\uffff"+
        "\x01\x6e\x01\uffff\x01\x65\x01\x73\x01\x63\x02\uffff\x01\x30\x01"+
        "\x67\x01\uffff\x01\x30\x01\x74\x01\x76\x04\uffff\x01\x65\x01\x30"+
        "\x01\uffff\x03\x30\x01\x64\x01\x74\x01\uffff\x01\x72\x01\uffff\x01"+
        "\x74\x01\x30\x01\x65\x01\x73\x01\uffff\x01\x30\x02\uffff\x01\x6e"+
        "\x01\uffff\x01\x74\x01\x30\x01\x63\x02\x30\x01\x74\x01\uffff\x01"+
        "\x30\x01\uffff\x01\x30\x01\x61\x01\x30\x04\uffff\x02\x30\x01\x69"+
        "\x01\x61\x01\uffff\x02\x30\x01\uffff\x02\x30\x01\uffff\x01\x74\x02"+
        "\uffff\x01\x30\x02\uffff\x01\x6c\x03\uffff\x01\x6e\x01\x6d\x04\uffff"+
        "\x01\x30\x01\uffff\x01\x30\x01\x67\x01\x70\x02\uffff\x02\x30\x02"+
        "\uffff";
    const string DFA31_maxS =
        "\x01\x7c\x01\x73\x01\x79\x01\x72\x01\x69\x01\x78\x01\x75\x01\x72"+
        "\x01\x6f\x01\x73\x01\x6f\x01\x69\x01\x6f\x02\x75\x01\x69\x01\x75"+
        "\x01\x6f\x01\x70\x01\x61\x01\x68\x01\x65\x01\x39\x04\uffff\x01\x3e"+
        "\x01\uffff\x01\x3d\x07\uffff\x02\x39\x02\uffff\x01\x7a\x04\uffff"+
        "\x01\x6c\x01\x79\x01\x7a\x01\x74\x01\x7a\x01\x73\x01\x6f\x01\x79"+
        "\x03\x73\x01\x64\x01\x63\x01\x74\x01\x72\x01\x6f\x01\x6c\x01\x6f"+
        "\x01\x76\x01\x75\x02\x7a\x01\x69\x01\x66\x01\x6b\x02\x6e\x01\x74"+
        "\x01\x6c\x01\uffff\x02\x7a\x01\x74\x01\x67\x01\x74\x01\x6d\x01\x62"+
        "\x01\x65\x01\x6d\x01\x70\x01\x69\x01\x64\x01\x6c\x01\x65\x01\x61"+
        "\x08\uffff\x01\x39\x01\uffff\x04\x7a\x01\uffff\x01\x77\x01\uffff"+
        "\x01\x74\x01\x73\x01\x7a\x01\x61\x01\x65\x01\x63\x01\x74\x01\x65"+
        "\x01\x7a\x01\x61\x01\x73\x01\x72\x01\x7a\x01\x6d\x01\x6c\x01\x75"+
        "\x01\x69\x01\x72\x02\x65\x01\x6f\x02\uffff\x01\x6e\x01\x74\x01\x65"+
        "\x01\x75\x01\x74\x01\x7a\x01\x6c\x01\uffff\x01\x65\x01\uffff\x01"+
        "\x65\x01\x68\x01\x6f\x01\x65\x01\x7a\x01\x65\x01\x73\x01\x6e\x01"+
        "\x65\x01\x7a\x01\x6f\x01\x61\x01\x75\x02\x72\x01\x39\x04\uffff\x01"+
        "\x65\x02\x7a\x01\x73\x01\uffff\x01\x75\x01\x74\x01\x7a\x01\x69\x01"+
        "\x7a\x01\uffff\x01\x70\x01\x74\x01\x61\x01\uffff\x02\x7a\x01\x70"+
        "\x01\x6e\x01\x7a\x03\x72\x04\x7a\x01\x74\x01\x68\x01\uffff\x01\x7a"+
        "\x02\x72\x01\x74\x01\x6e\x01\x63\x01\uffff\x01\x7a\x01\x74\x01\x7a"+
        "\x01\x73\x01\uffff\x01\x6e\x01\x74\x01\x65\x01\x7a\x01\x65\x01\x7a"+
        "\x01\x2d\x01\x65\x02\uffff\x01\x7a\x01\x6c\x01\x65\x01\uffff\x01"+
        "\x6e\x01\uffff\x01\x65\x01\x73\x01\x63\x02\uffff\x01\x7a\x01\x67"+
        "\x01\uffff\x01\x7a\x01\x74\x01\x76\x04\uffff\x01\x65\x01\x7a\x01"+
        "\uffff\x03\x7a\x01\x64\x01\x74\x01\uffff\x01\x72\x01\uffff\x01\x74"+
        "\x01\x7a\x01\x65\x01\x73\x01\uffff\x01\x7a\x02\uffff\x01\x6e\x01"+
        "\uffff\x01\x74\x01\x7a\x01\x63\x02\x7a\x01\x74\x01\uffff\x01\x7a"+
        "\x01\uffff\x01\x7a\x01\x61\x01\x7a\x04\uffff\x02\x7a\x01\x69\x01"+
        "\x61\x01\uffff\x02\x7a\x01\uffff\x02\x7a\x01\uffff\x01\x74\x02\uffff"+
        "\x01\x7a\x02\uffff\x01\x6c\x03\uffff\x01\x6e\x01\x6d\x04\uffff\x01"+
        "\x7a\x01\uffff\x01\x7a\x01\x67\x01\x70\x02\uffff\x02\x7a\x02\uffff";
    const string DFA31_acceptS =
        "\x17\uffff\x01\x3d\x01\x3e\x01\x3f\x01\x40\x01\uffff\x01\x42\x01"+
        "\uffff\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x02"+
        "\uffff\x01\x50\x01\x51\x01\uffff\x01\x53\x01\x55\x01\x52\x01\x57"+
        "\x1d\uffff\x01\x54\x0f\uffff\x01\x3b\x01\x3c\x01\x4f\x01\x41\x01"+
        "\x43\x01\x44\x01\x45\x01\x46\x01\uffff\x01\x56\x04\uffff\x01\x04"+
        "\x01\uffff\x01\x07\x15\uffff\x01\x1b\x01\x20\x07\uffff\x01\x28\x01"+
        "\uffff\x01\x29\x10\uffff\x01\x01\x01\x02\x01\x03\x01\x05\x04\uffff"+
        "\x01\x0b\x05\uffff\x01\x11\x03\uffff\x01\x15\x0e\uffff\x01\x26\x06"+
        "\uffff\x01\x2f\x04\uffff\x01\x34\x08\uffff\x01\x08\x01\x09\x03\uffff"+
        "\x01\x0e\x01\uffff\x01\x10\x03\uffff\x01\x16\x01\x17\x02\uffff\x01"+
        "\x1a\x03\uffff\x01\x1f\x01\x21\x01\x22\x01\x23\x02\uffff\x01\x27"+
        "\x05\uffff\x01\x30\x01\uffff\x01\x32\x04\uffff\x01\x38\x01\uffff"+
        "\x01\x3a\x01\x4e\x01\uffff\x01\x0a\x06\uffff\x01\x18\x01\uffff\x01"+
        "\x1c\x03\uffff\x01\x25\x01\x2a\x01\x2b\x01\x2c\x04\uffff\x01\x35"+
        "\x02\uffff\x01\x39\x02\uffff\x01\x0d\x01\uffff\x01\x12\x01\x13\x01"+
        "\uffff\x01\x19\x01\x1d\x01\uffff\x01\x24\x01\x2d\x01\x2e\x02\uffff"+
        "\x01\x36\x01\x37\x01\x06\x01\x0c\x01\uffff\x01\x14\x03\uffff\x01"+
        "\x0f\x01\x1e\x02\uffff\x01\x31\x01\x33";
    const string DFA31_specialS =
        "\u0135\uffff}>";
    static readonly string[] DFA31_transitionS = {
            "\x02\x2d\x02\uffff\x01\x2d\x12\uffff\x01\x2d\x01\x1c\x01\x28"+
            "\x01\x24\x01\uffff\x01\x21\x01\uffff\x01\x2a\x01\x18\x01\x19"+
            "\x01\x20\x01\x1f\x01\x17\x01\x2b\x01\x16\x01\x1e\x01\x25\x09"+
            "\x26\x01\x29\x01\uffff\x01\x1b\x01\x1a\x01\x1d\x01\x23\x01\x2c"+
            "\x1a\uffff\x01\x28\x04\uffff\x01\x28\x01\x01\x01\x02\x01\x03"+
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01"+
            "\x27\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x02\x27\x01\x0f\x01\x10"+
            "\x01\x11\x01\x12\x01\x13\x01\x14\x01\x27\x01\x15\x01\x27\x01"+
            "\uffff\x01\x22",
            "\x01\x2e\x01\uffff\x01\x2f\x04\uffff\x01\x30",
            "\x01\x31\x13\uffff\x01\x32",
            "\x01\x33\x10\uffff\x01\x34",
            "\x01\x35\x03\uffff\x01\x36\x03\uffff\x01\x37",
            "\x01\x38\x01\uffff\x01\x39\x04\uffff\x01\x3a\x04\uffff\x01"+
            "\x3b",
            "\x01\x3c\x02\uffff\x01\x3d\x02\uffff\x01\x3e",
            "\x01\x3f",
            "\x01\x40\x0d\uffff\x01\x41",
            "\x01\x42\x04\uffff\x01\x43",
            "\x01\x44",
            "\x01\x45\x03\uffff\x01\x46",
            "\x01\x47\x05\uffff\x01\x48",
            "\x01\x4b\x47\uffff\x01\x49\x05\uffff\x01\x4a",
            "\x01\x4c\x03\uffff\x01\x4d\x02\uffff\x01\x4e",
            "\x01\x4f",
            "\x01\x50\x09\uffff\x01\x51\x05\uffff\x01\x52",
            "\x01\x53\x01\x54\x05\uffff\x01\x55",
            "\x01\x56\x01\uffff\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b\x05\uffff\x0a\x5d",
            "",
            "",
            "",
            "",
            "\x01\x5f\x01\x5e",
            "",
            "\x01\x61",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x63",
            "\x0a\x63",
            "",
            "",
            "\x1a\x2c",
            "",
            "",
            "",
            "",
            "\x01\x65",
            "\x01\x66\x14\uffff\x01\x67",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x02\x27\x01\x68\x17\x27",
            "\x01\x6a",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f\x05\uffff\x01\x70\x06\uffff\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76\x0a\uffff\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x0d\x27\x01\x7e\x04\x27"+
            "\x01\x7f\x01\u0080\x06\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x03\x27\x01\u008b\x16"+
            "\x27",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f\x08\uffff\x01\u0090\x07\uffff\x01\u0091",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\u009c",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00a1",
            "",
            "\x01\u00a2\x0e\uffff\x01\u00a3",
            "\x01\u00a4",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x01\u00b5",
            "\x01\u00b6",
            "\x01\u00b7\x09\uffff\x01\u00b8",
            "",
            "",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00bf",
            "",
            "\x01\u00c0",
            "",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x01\u00c3",
            "\x01\u00c4",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00c6",
            "\x01\u00c7",
            "\x01\u00c8",
            "\x01\u00c9",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00cb",
            "\x01\u00cc",
            "\x01\u00cd",
            "\x01\u00ce\x03\uffff\x01\u00cf",
            "\x01\u00d0",
            "\x0a\u00d1",
            "",
            "",
            "",
            "",
            "\x01\u00d2",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00d5",
            "",
            "\x01\u00d6",
            "\x01\u00d7",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00d9",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00db",
            "\x01\u00dc",
            "\x01\u00dd",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00e0",
            "\x01\u00e1",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00e3",
            "\x01\u00e4",
            "\x01\u00e5",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00ea",
            "\x01\u00eb",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00ed",
            "\x01\u00ee",
            "\x01\u00ef",
            "\x01\u00f0",
            "\x01\u00f1",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00f3",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00f5",
            "",
            "\x01\u00f6",
            "\x01\u00f7",
            "\x01\u00f8",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00fa",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00fc",
            "\x01\u00fd",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u00ff",
            "\x01\u0100",
            "",
            "\x01\u0101",
            "",
            "\x01\u0102",
            "\x01\u0103",
            "\x01\u0104",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0106",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0108",
            "\x01\u0109",
            "",
            "",
            "",
            "",
            "\x01\u010a",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u010f",
            "\x01\u0110",
            "",
            "\x01\u0111",
            "",
            "\x01\u0112",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0114",
            "\x01\u0115",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "",
            "\x01\u0117",
            "",
            "\x01\u0118",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u011a",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u011d",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0120",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0124",
            "\x01\u0125",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u012a",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "",
            "\x01\u012c",
            "",
            "",
            "",
            "\x01\u012d",
            "\x01\u012e",
            "",
            "",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x01\u0131",
            "\x01\u0132",
            "",
            "",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "\x0a\x27\x25\uffff\x01\x27\x01\uffff\x1a\x27",
            "",
            ""
    };

    static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
    static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
    static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
    static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
    static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
    static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
    static readonly short[][] DFA31_transition = DFA.UnpackEncodedStringArray(DFA31_transitionS);

    protected class DFA31 : DFA
    {
        public DFA31(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 31;
            this.eot = DFA31_eot;
            this.eof = DFA31_eof;
            this.min = DFA31_min;
            this.max = DFA31_max;
            this.accept = DFA31_accept;
            this.special = DFA31_special;
            this.transition = DFA31_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( ALL | AND | ANY | AS | ASC | BETWEEN | BY | CASE | CAST | CROSS | DAY | DEFAULT | DELETE | DESC | DISTINCT | ELSE | END | ESCAPE | EXISTS | EXTRACT | FOR | FROM | FULL | GROUP | HAVING | HOUR | IN | INNER | INSERT | INTERVAL | INTO | IS | JOIN | LEFT | LIKE | MINUTE | MONTH | NOT | NULL | ON | OR | ORDER | OUTER | RIGHT | SECOND | SELECT | SET | SOME | SUBSTRING | THEN | TIMESTAMP | TOP | UNION | UPDATE | VALUES | WHEN | WHERE | YEAR | DOT_STAR | DOT | COMMA | LPAREN | RPAREN | ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN | DIVIDE | PLUS | STAR | MOD | STRCONCAT | PLACEHOLDER | MAccessDateTime | Iso8601DateTime | Number | NonQuotedIdentifier | QuotedIdentifier | Variable | AsciiStringLiteral | UnicodeStringLiteral | MINUS | COLON | Whitespace );"; }
        }

    }

 
    
}
}