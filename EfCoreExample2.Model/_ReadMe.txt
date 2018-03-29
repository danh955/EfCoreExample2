
Code first entity framework
	http://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx
	https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext

How to allow migration for a console application?
	https://stackoverflow.com/questions/48363173/how-to-allow-migration-for-a-console-application
	https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation

Migration
	Microsoft.EntityFrameworkCore.Tools

	add-migration InitialCreate

	Add-Migration: Creates a new migration class as per specified name with the Up() and Down() methods.
	Update-Database: Executes the last migration file created by the Add-Migration command and applies changes to the database schema.
