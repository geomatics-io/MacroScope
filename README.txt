MacroScope - portable SQL ADO.NET provider

MacroScope is a .NET library (2 libraries, actually) automagically
transforming SQL commands to a form expected by different database
engines, so that (for example) the MS SQL Server-specific construction

SELECT TOP 10 * FROM table_name

becomes

SELECT * FROM table_name WHERE rownum <= 10

when used for Oracle. This is done transparently behind the standard
ASP.NET interface, without littering code with conditionals and
leaving the application programmer free to concentrate on the
application logic.

The transformation is implemented by a custom ADO.NET database
provider, which parses the SQL passed to it and then uses (hardcoded
but encapsulated) rules to recognize and rewrite constructions
incompatible with the target database. As an added benefit, the parsed
tree is available to the application, enabling custom SQL
transformations (adding selected columns, conditions, clauses etc.) on
an object model based on the standard SQL grammar, even for commands
not known at compile time and passed to the application as simple
strings.

MacroScope supports a practically useful subset of SQL commands
INSERT, SELECT, UPDATE and DELETE, for 4 database backends: MySQL,
MS SQL Server, Oracle and MS Access. It is used in production, but new
users will probably find the list of supported backends incomplete,
some constructions they'd like to use unsupported and many
incompatibilities remaining (especially for MS Access - there's a lot
things it just doesn't do, and no amount of SQL rewriting is going to
make the backend more capable). These limitations are an important
reason for releasing the component as Open Source, so that many users
can improve it for their specific needs and share their improvements
for our mutual benefit.
