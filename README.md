# &#x1F488; **Eau Claire's Salon** &#x1F488;

#### **By Casey Hill**

#### A straightforward Salon Management System in the form of a web application that allows the user to add both Clients and Stylists to an internal database &#x1F487; &#x2702; &#x1F511;

#### ...._"The way we present ourselves can tell a larger narrative about what we want the world to think about us."_ - JVN

## **Technologies Used**

-   C#
-   .NET 6.0.402
-   Entity Framework Core version 6.0
-   dontnet CLI
-   MSBuild
-   VS Code
-   MySql Server
-   MySQL Workbench
-   SQL
-   git
-   GitHub

## **Description**

Welcome to Eau Claire's Hair Salon!

This Salon Management System helps manage Client and Stylist information to help keep operations running smoothly. Add new Clients to their Stylist to keep organized and keep scheduling in check.

Use the links at the bottom of the page to navigate to the Client and Stylist pages.

## **Setup/Installation Requirements** &#x1F4BB;

### **Initial Setup**

-   Clone this repository to your local machine.
-   Open VS Code (or your IDE of choice).
-   Open the top level directory you just cloned.

### **Database Setup**

-   Use a RDBMS like MySql to import/upload the `casey_hill.sql` file to create your database.
-   In your HairSalon folder, create a file with the name `appsettings.json` and copy and past the following code into this file:

    {<br>
    &emsp;&emsp;"ConnectionStrings": {<br>
    &emsp;&emsp;&emsp;&emsp;"DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=[USERNAME-GOES-HERE];pwd=[PASSWORD-GOES-HERE];",<br>
    &emsp;&emsp;&emsp;&emsp;"TestConnection": "Server=localhost;Port=3306;database=hair_salon_test;uid=[USERNAME-GOES-HERE];pwd=[PASSWORD-GOES-HERE];"<br>
    &emsp;&emsp;}<br>
    }

    _Note: The TestConnection is used for testing purposes but there are currently no test files in this project. If you would like to test, create a backup of the db and append '\_test' to the end of the new schema_

-   Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.

-   In your terminal:

        -   Change directory (cd) to HairSalon.
        -   Enter `dotnet build` into your terminal.
        -   Enter `dotnet watch run`.

-   A web page will automatically open in your browser
-   Use the navigation at the bottom of the page to view Clients or Stylists (both will be empty to start)
-   You must first create a Stylist before you can start adding Clients. You can create a Stylist from either of the two menu options to start.
-   Follow the links based on what every your needs are.

That's it!

#### Debugging

If the program does not run, try the following:

-   Check that you have the appropriate packages installed to run dotnet
    -   In your Terminal, enter the following commands:<br>
        `$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`<br>
        `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`
-   Try creating a `global.json` file in the Bakery.Tests dir that contains the following code to override the default version:<br>
    {<br>
    &emsp;&emsp; "sdk": {<br>
    &emsp;&emsp;&emsp;&emsp;"version": "6.0.402"<br>
    &emsp;&emsp;}<br>
    }

## **Known Bugs**

-   There is currently neither a Delete nor Edit/Update functionality from within the program.
    To delete or edit, use you RDBMS Software or Querey MySql Server at the command line with your existing local setup.

## License

Please contact [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=You%20are%20amazing...) with any the following:

-   Found bugs &#x1F41E;
-   Alterations and improvements
-   General Questions
-   Any contributions you would like to make! &#x1F5DD;

Copyright (c) 06/16/2023 Casey Hill
