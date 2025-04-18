﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScaffoldingTester.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ScaffoldingTester.Models
{
    public partial interface INorthwindContextProcedures
    {
        Task<List<CustOrderHistResult>> CustOrderHistAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<CustOrdersDetailResult>> CustOrdersDetailAsync(int? OrderID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<CustOrdersOrdersResult>> CustOrdersOrdersAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<EmployeeSalesbyCountryResult>> EmployeeSalesbyCountryAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<MultiSetResult>> MultiSetAsync(DateTime? Year, decimal? ProductValue, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<OutputScenariosResult>> OutputScenariosAsync(short? Year, OutputParameter<int?> ProductCount, OutputParameter<string> Description, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesbyYearResult>> SalesbyYearAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string CategoryName, string OrdYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<TenMostExpensiveProductsResult>> TenMostExpensiveProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
