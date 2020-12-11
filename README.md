README

# Subject - PROG7311 POE
## Author & Developer
Name:  Jacques Olivier

Student Number: 18008247

Year: BCAD3 2020

Website: Runs Locally

**__Disclaimer: all information described is for the project__**

## Surf Local Overview
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

## Login Details for Admin
email: admin@surflocal.com

password: Password1

## How to run Project
### Requirements
-	Visual Studio 2019 Community Edition (v.16.7.2)
-	Asp.Net 4.7
-	Sql Server (any year)
-	IIS Express
-	Internet Browser (preferably Google Chrome)

### Steps:
1.	Open the solution in Visual Studio 2019
2.	Clean and Rebuild the Solution 
3.	Github was used for production, make sure you are on “master” branch
4.	To run, click “ISS Express" (google chrome)

### Issues:
1. Missing Project
    *	If project is missing from the solution,
    *	Right-click and select “Load”
    *	Browse to the project and select it

2. Asp.Net version
    *	If you don’t have Asp.Net 4.7,
    *	Right-click LibraryDeweyApp
    *	Select properties
    *	Under Target Framework, change it to the desired framework
    *	Clean and rebuild project

## Issues & Solutions:
During the creation of this app, I ran into various issues along the way.

1. Two Different dB Contexts
    *	This made it a bit difficult to implement migrations for the project.
    *	Found forums and discussions how to add a migration using a specific context type.

2. Boostrap limitation
    *	The landing page has a video playing in the background, and I wanted it to be fullscreen but boostrap restricited it.
    *	Added properties to the video to make it absolute and changed the Z-index.

## Software specs
* Product Version - Microsoft Visual Studio Community 2019
* VS Version - 16.7.2
* .NET Framework- 4.8.03752
