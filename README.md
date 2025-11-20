🍔 GoodHamburger

A Blazor-based food ordering website developed for a technical test at
STgen.

This project simulates a small food-ordering system with sandwiches,
fries, and drinks.
Although the Cart and Checkout logic wasn’t fully completed, the project
served as a great way to practice Blazor and frontend
structure.

------------------------------------------------------------------------

🏠 Home Page Preview

![HomePage](https://github.com/wazeveve/GoodHamburger/blob/main/GoodHamburguer/Docs/HomePage.jpeg)

------------------------------------------------------------------------

🚀 Overview

The goal of this project was to create a simple and functional
food-ordering website featuring:

-   🍔 Burgers
-   🍟 Fries
-   🥤 Drinks

------------------------------------------------------------------------

🧰 How to Run the Application

1.  Clone or download this repository: git clone
    https://github.com/wazeveve/GoodHamburger.git

2.  Open the solution in Visual Studio.

3.  Press Ctrl + F5 to run the project.

The database setup is required just to populate the Dishes.

------------------------------------------------------------------------

🔢 How the Discount Is Calculated

The discount logic is inside Order.cs.

Step-by-step logic:

1.  The system checks three boolean flags:

    -   hasSandwich
    -   hasFries
    -   hasDrink

2.  Based on combinations:

    -   Sandwich + Fries + Drink → 20%
    -   Sandwich + Drink → 15%
    -   Sandwich + Fries → 10%
    -   Anything else → 0%

3.  Final price formula: total -= total * discount

e.g: 10 - (10 × 0.20) = 8

------------------------------------------------------------------------

📁 Project Structure
```
GoodHamburger/
│
├── GoodHamburger/ Main Blazor project
│ ├──Components/ Pages & UI components
│ ├── Controllers/ OrderController (API simulation)
│ ├── Docs/ Images and documentation assets
│ ├── Migrations/ EF Core migrations
│ ├── Models/ C# domain classes
│ ├── Services/ Business services (not fully functional)
│ ├── Shared/ Shared components (DishCard, etc.)
│ └── wwwroot/ CSS, images, fonts
│
├── GoodHamburger.sln Visual Studio solution
└── README.md Project documentation
```
------------------------------------------------------------------------

🧪 API Simulation

The API is not real
it is simulated using OrderController.
It returns test data so the UI works as if it were connected to a live
backend.
Unfortunately, it didn’t work.
