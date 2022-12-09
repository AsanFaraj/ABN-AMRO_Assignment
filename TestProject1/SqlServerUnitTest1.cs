using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace TestProject1
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_FizzBuzzCalculationSPTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCountIs100;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number3ShouldReturnFirstName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number6ShouldReturnFirstName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number9ShouldReturnFirstName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number5ShouldReturnLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number10ShouldReturnLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number20ShouldReturnLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number15ShouldReturnFirstAndLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number30ShouldReturnFirstAndLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number45ShouldReturnFirstAndLastName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number1ShouldReturn1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number7ShouldReturn7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Number17ShouldReturn17;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_FizzBuzzCalculationSPTest_PretestAction;
            this.dbo_FizzBuzzCalculationSPTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_FizzBuzzCalculationSPTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckRowCountIs100 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Number3ShouldReturnFirstName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number6ShouldReturnFirstName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number9ShouldReturnFirstName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number5ShouldReturnLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number10ShouldReturnLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number20ShouldReturnLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number15ShouldReturnFirstAndLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number30ShouldReturnFirstAndLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number45ShouldReturnFirstAndLastName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number1ShouldReturn1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number7ShouldReturn7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Number17ShouldReturn17 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_FizzBuzzCalculationSPTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_FizzBuzzCalculationSPTest_TestAction
            // 
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(CheckRowCountIs100);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number3ShouldReturnFirstName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number6ShouldReturnFirstName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number9ShouldReturnFirstName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number5ShouldReturnLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number10ShouldReturnLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number20ShouldReturnLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number15ShouldReturnFirstAndLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number30ShouldReturnFirstAndLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number45ShouldReturnFirstAndLastName);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number1ShouldReturn1);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number7ShouldReturn7);
            dbo_FizzBuzzCalculationSPTest_TestAction.Conditions.Add(Number17ShouldReturn17);
            resources.ApplyResources(dbo_FizzBuzzCalculationSPTest_TestAction, "dbo_FizzBuzzCalculationSPTest_TestAction");
            // 
            // dbo_FizzBuzzCalculationSPTestData
            // 
            this.dbo_FizzBuzzCalculationSPTestData.PosttestAction = null;
            this.dbo_FizzBuzzCalculationSPTestData.PretestAction = dbo_FizzBuzzCalculationSPTest_PretestAction;
            this.dbo_FizzBuzzCalculationSPTestData.TestAction = dbo_FizzBuzzCalculationSPTest_TestAction;
            // 
            // CheckRowCountIs100
            // 
            CheckRowCountIs100.Enabled = true;
            CheckRowCountIs100.Name = "CheckRowCountIs100";
            CheckRowCountIs100.ResultSet = 1;
            CheckRowCountIs100.RowCount = 100;
            // 
            // Number3ShouldReturnFirstName
            // 
            Number3ShouldReturnFirstName.ColumnNumber = 2;
            Number3ShouldReturnFirstName.Enabled = true;
            Number3ShouldReturnFirstName.ExpectedValue = "Asan";
            Number3ShouldReturnFirstName.Name = "Number3ShouldReturnFirstName";
            Number3ShouldReturnFirstName.NullExpected = false;
            Number3ShouldReturnFirstName.ResultSet = 1;
            Number3ShouldReturnFirstName.RowNumber = 3;
            // 
            // Number6ShouldReturnFirstName
            // 
            Number6ShouldReturnFirstName.ColumnNumber = 2;
            Number6ShouldReturnFirstName.Enabled = true;
            Number6ShouldReturnFirstName.ExpectedValue = "Asan";
            Number6ShouldReturnFirstName.Name = "Number6ShouldReturnFirstName";
            Number6ShouldReturnFirstName.NullExpected = false;
            Number6ShouldReturnFirstName.ResultSet = 1;
            Number6ShouldReturnFirstName.RowNumber = 6;
            // 
            // Number9ShouldReturnFirstName
            // 
            Number9ShouldReturnFirstName.ColumnNumber = 2;
            Number9ShouldReturnFirstName.Enabled = true;
            Number9ShouldReturnFirstName.ExpectedValue = "Asan";
            Number9ShouldReturnFirstName.Name = "Number9ShouldReturnFirstName";
            Number9ShouldReturnFirstName.NullExpected = false;
            Number9ShouldReturnFirstName.ResultSet = 1;
            Number9ShouldReturnFirstName.RowNumber = 9;
            // 
            // Number5ShouldReturnLastName
            // 
            Number5ShouldReturnLastName.ColumnNumber = 2;
            Number5ShouldReturnLastName.Enabled = true;
            Number5ShouldReturnLastName.ExpectedValue = "Faraj";
            Number5ShouldReturnLastName.Name = "Number5ShouldReturnLastName";
            Number5ShouldReturnLastName.NullExpected = false;
            Number5ShouldReturnLastName.ResultSet = 1;
            Number5ShouldReturnLastName.RowNumber = 5;
            // 
            // Number10ShouldReturnLastName
            // 
            Number10ShouldReturnLastName.ColumnNumber = 2;
            Number10ShouldReturnLastName.Enabled = true;
            Number10ShouldReturnLastName.ExpectedValue = "Faraj";
            Number10ShouldReturnLastName.Name = "Number10ShouldReturnLastName";
            Number10ShouldReturnLastName.NullExpected = false;
            Number10ShouldReturnLastName.ResultSet = 1;
            Number10ShouldReturnLastName.RowNumber = 10;
            // 
            // Number20ShouldReturnLastName
            // 
            Number20ShouldReturnLastName.ColumnNumber = 2;
            Number20ShouldReturnLastName.Enabled = true;
            Number20ShouldReturnLastName.ExpectedValue = "Faraj";
            Number20ShouldReturnLastName.Name = "Number20ShouldReturnLastName";
            Number20ShouldReturnLastName.NullExpected = false;
            Number20ShouldReturnLastName.ResultSet = 1;
            Number20ShouldReturnLastName.RowNumber = 20;
            // 
            // Number15ShouldReturnFirstAndLastName
            // 
            Number15ShouldReturnFirstAndLastName.ColumnNumber = 2;
            Number15ShouldReturnFirstAndLastName.Enabled = true;
            Number15ShouldReturnFirstAndLastName.ExpectedValue = "Asan Faraj";
            Number15ShouldReturnFirstAndLastName.Name = "Number15ShouldReturnFirstAndLastName";
            Number15ShouldReturnFirstAndLastName.NullExpected = false;
            Number15ShouldReturnFirstAndLastName.ResultSet = 1;
            Number15ShouldReturnFirstAndLastName.RowNumber = 15;
            // 
            // Number30ShouldReturnFirstAndLastName
            // 
            Number30ShouldReturnFirstAndLastName.ColumnNumber = 2;
            Number30ShouldReturnFirstAndLastName.Enabled = true;
            Number30ShouldReturnFirstAndLastName.ExpectedValue = "Asan Faraj";
            Number30ShouldReturnFirstAndLastName.Name = "Number30ShouldReturnFirstAndLastName";
            Number30ShouldReturnFirstAndLastName.NullExpected = false;
            Number30ShouldReturnFirstAndLastName.ResultSet = 1;
            Number30ShouldReturnFirstAndLastName.RowNumber = 30;
            // 
            // Number45ShouldReturnFirstAndLastName
            // 
            Number45ShouldReturnFirstAndLastName.ColumnNumber = 2;
            Number45ShouldReturnFirstAndLastName.Enabled = true;
            Number45ShouldReturnFirstAndLastName.ExpectedValue = "Asan Faraj";
            Number45ShouldReturnFirstAndLastName.Name = "Number45ShouldReturnFirstAndLastName";
            Number45ShouldReturnFirstAndLastName.NullExpected = false;
            Number45ShouldReturnFirstAndLastName.ResultSet = 1;
            Number45ShouldReturnFirstAndLastName.RowNumber = 45;
            // 
            // Number1ShouldReturn1
            // 
            Number1ShouldReturn1.ColumnNumber = 2;
            Number1ShouldReturn1.Enabled = true;
            Number1ShouldReturn1.ExpectedValue = "1";
            Number1ShouldReturn1.Name = "Number1ShouldReturn1";
            Number1ShouldReturn1.NullExpected = false;
            Number1ShouldReturn1.ResultSet = 1;
            Number1ShouldReturn1.RowNumber = 1;
            // 
            // Number7ShouldReturn7
            // 
            Number7ShouldReturn7.ColumnNumber = 2;
            Number7ShouldReturn7.Enabled = true;
            Number7ShouldReturn7.ExpectedValue = "7";
            Number7ShouldReturn7.Name = "Number7ShouldReturn7";
            Number7ShouldReturn7.NullExpected = false;
            Number7ShouldReturn7.ResultSet = 1;
            Number7ShouldReturn7.RowNumber = 7;
            // 
            // Number17ShouldReturn17
            // 
            Number17ShouldReturn17.ColumnNumber = 2;
            Number17ShouldReturn17.Enabled = true;
            Number17ShouldReturn17.ExpectedValue = "17";
            Number17ShouldReturn17.Name = "Number17ShouldReturn17";
            Number17ShouldReturn17.NullExpected = false;
            Number17ShouldReturn17.ResultSet = 1;
            Number17ShouldReturn17.RowNumber = 17;
            // 
            // dbo_FizzBuzzCalculationSPTest_PretestAction
            // 
            resources.ApplyResources(dbo_FizzBuzzCalculationSPTest_PretestAction, "dbo_FizzBuzzCalculationSPTest_PretestAction");
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_FizzBuzzCalculationSPTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_FizzBuzzCalculationSPTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_FizzBuzzCalculationSPTestData;
    }
}
