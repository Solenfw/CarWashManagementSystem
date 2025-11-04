using CarWashManagement.Core.FileHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core.Managers
{
    public class ExpenseManager
    {
        private readonly IFileHandler<Expense> expenseFileHandler;
        private List<Expense> expenses;

        public ExpenseManager(IFileHandler<Expense> expenseFileHandler)
        {
            this.expenseFileHandler = expenseFileHandler;
            expenses = expenseFileHandler.Load(); // Load existing expenses from expenses.txt file
        }

        // Method to create a new expense and save it to the expenses.txt file
        public void CreateExpense(string description, decimal amount)
        {
            Expense newExpense = new Expense
            {
                Description = description,
                Amount = amount
            };

            expenses.Add(newExpense);
            expenseFileHandler.Save(expenses); // Save updated expenses list to expenses.txt file
        }

        // Method to get all expenses for a specific month and year
        public List<Expense> GetExpensesForMonth(int year, int month)
        {
            return expenses
                .Where(e => e.Date.Year == year && e.Date.Month == month)
                .ToList();
        }

        // Method to get all expenses
        public List<Expense> GetAllExpenses()
        {
            return expenses
                .OrderByDescending(e => e.Date)
                .ToList();
        }
    }
}
