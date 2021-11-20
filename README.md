README
# E-commerce Store Prototype

1. [Surf Local Overview](#surf-local-overview)
    1. [Key Notes](#key-notes)
    2. [Tech Stack](#tech-stack)
    3. [Login Details for Admin](#login-details-for-admin)
2. [Getting Started](#getting-started)
    1. [Requirements](#requirements)
    2. [Steps](#steps)
    3. [Issues & Solutions](#issues-and-solutions)
3. [Issues Encountered](#issues-encountered)

## Surf Local Overview

**__Disclaimer: All information described is for the project scope and case study__**

Year: 2020 (Final year of Studies)

Surf Local is a South African e-commerce store which specializes in surfing gear. This protoype has been created for the shareholder AMCE INC (fictional), to demonstrate why AMCE INC should chose our development team for the project. 
  
The website is curated according to the requirements of AMCE INC, which wanted to develop an e-commerce website with the following functionalities:
- Have a database of products divided into different categories
- Provide a search feature for the products without logging in
- Incorporate role functinoality of Customer and Employee
- User is required to log in in order to place an order or access any user information
- Implement shopping cart and proceed to checkout to complete transaction
- Do not integrate any payment portals, assume transaction was successful
- An employee shall be able to view the number of orders in each product category over time
- Include sameple data for prototype

### Key Notes
* Data is stored in .mdf files under the App_Data folder. The connection string points to this attached file.
* There may be bugs and don't plan on making any updates. (unless there is a need for it).
* Admin has the following CRUD functionality
  * Products
  * Categories
  * Users
  * Images 
* Other features were added that weren't required in the scope of the project.

### Tech Stack
The following tech stack was utilized:
1. dotnet framework (*back-end*)
2. Bootstrap (*front-end styling*)
3. SQL Server (*local database*)
4. Azure (*hosting*)

### Login Details for Admin
|Email| Password |
|---|---|
| admin@surflocal.com | Password1|

## Getting Started

### Requirements
-	[Visual Studio](https://visualstudio.microsoft.com/vs/community/)
-	[Asp.Net](https://dotnet.microsoft.com/apps/aspnet)
-	[IIS Express](https://www.microsoft.com/en-us/download/details.aspx?id=48264)
-	[Internet Browser](https://www.google.com/chrome/) (Google Chrome)

### Steps
1. [Clone](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository#cloning-a-repository)  or [Fork](https://docs.github.com/en/get-started/quickstart/fork-a-repo#forking-a-repository) the repo.
1.	In the cloned folder, double-click the .sln file to open the solution.
2.	Clean and Rebuild the Solution.
4.	To run, click “ISS Express" (google chrome).

### Issues and Solutions

**1. Project file has been unloaded.**

*	In the Solution Explorer, right-click the missing project and select 'Reload Project'.

**2. Project file has been removed.**

*   Right-click the Solution and select 'Add' -> 'Existing Project'.
*   Navitgate to the cloned project to the following directory '[yourpath]\ecommerce-store-prototype\SurfLocalShop\'.
*   Find the LibraryDeweyApp.csproj file, and click 'Open'.
*   Click the green arrow to run the project.

**3. Asp.Net version is not supported.**

*	Right-click 'SurfLocalShop' project in the Solution Explorer and select 'Properties'.
*	In the left menu, make sure 'Applicaiton' is selected
*	Under Target Framework, change it to the desired framework.
*	Clean and rebuild the project in the Solution Explorer.

## Issues encountered
During the creation of this app, I ran into various issues along the way.

1. Two Different dB Contexts
    *	This made it a bit difficult to implement migrations for the project.
    *	Found forums and discussions how to add a migration using a specific context type.

2. Boostrap limitation
    *	The landing page has a video playing in the background, and I wanted it to be fullscreen but boostrap restricited it.
    *	Added properties to the video to make it absolute and changed the Z-index.

## Software specs

These are are the software specifications when the project was created.
* Product Version - Microsoft Visual Studio Community 2019
* VS Version - 16.7.2
* .NET Framework- 4.8.03752
