# Calorie Calculator

A simple ASP.NET Core MVC web application to calculate daily calorie requirements based on user input.

## Features

- User inputs for age, gender, weight, height, and activity level.
- Calculation of daily calorie requirements using the Harris-Benedict equation.
- Responsive design using Bootstrap.

## Prerequisites

- .NET Core SDK
- Visual Studio or Visual Studio Code

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/salemovic99/CalorieCalculatorApp.git
   cd CalorieCalculatorApp

## Usage

    Enter your age, gender, weight (in kg), height (in cm), and activity level.
    Click the "Calculate" button to see your daily calorie requirement.

## Project Structure

    Controllers
        CalorieCalculatorController.cs: Handles the logic for displaying the form and calculating the calories.
    Models
        CalorieCalculatorModel.cs: Represents the form data and calculation logic.
    Views
        Index.cshtml: The main view containing the form and result display.

## Calculation Logic

The Harris-Benedict equation is used to estimate the daily calorie requirements:

    For men: BMR = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age)
    For women: BMR = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age)

The BMR is then multiplied by the activity level to get the daily calorie requirement:

    Sedentary (little or no exercise): Activity Level = 1.2
    Lightly active (light exercise/sports 1-3 days/week): Activity Level = 1.375
    Moderately active (moderate exercise/sports 3-5 days/week): Activity Level = 1.55
    Very active (hard exercise/sports 6-7 days a week): Activity Level = 1.725
    Super active (very hard exercise/physical job): Activity Level = 1.9

## Contributing

Contributions are welcome! Please fork this repository and submit a pull request for any features, bug fixes, or enhancements.
