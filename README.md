# Simple Student Information System - MVC4, EF5 Code First, Domain-centric

This is a very very simple app I created to apply my newly acquired knowledge on Domain-Centric Design

Steps to be able to run this in Visual studio 2012
1. Run the project StudInfoSys.DatabaseInitializationConsoleApp



JMF: Major Steps made when creating this project
1. Created Models (inside Core project)
2. Added EF5 in Infrastructure project using Nuget
3. Created EF DbContext named EFStudInfoSysContext (inside Infrastructure project)
4. Added EF Migrations (Infrastructure)
5. Added configuration/mapping of Entity classes to database tables (Infrastructure)
6. Created a console app for database initialization (StudInfoSys.DatabaseInitializationConsoleApp)