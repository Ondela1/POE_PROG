using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplication
{
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = new Recipe();

            // TODO: Add code to get input from the user and populate the recipe object

            recipes.Add(recipe);
            MessageBox.Show("Recipe added successfully!");
        }

        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes found.");
                return;
            }

            Recipe selectedRecipe = recipeListBox.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                // TODO: Show the selected recipe details in a new window or dialog
                MessageBox.Show($"Name: {selectedRecipe.Name} " +
                                $"Total Calories: {selectedRecipe.CalculateTotalCalories()}");
            }
            else
            {
                MessageBox.Show("Please select a recipe.");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

    // Remaining Recipe and Ingredient classes remain the same
}
