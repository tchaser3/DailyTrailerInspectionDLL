/* Title:           Daily Trailer Inspection Class
 * Date:            9-17-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for daily trailer inspections */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DailyTrailerInspectionDLL
{
    public class DailyTrailerInspectionClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        DailyTrailerInspectionDataSet aDailyTrailerInspectionDataSet;
        DailyTrailerInspectionDataSetTableAdapters.dailytrailerinspectionTableAdapter aDailyTrailerInspectionTableAdapter;

        InsertDailyTrailerInspectionEntryTableAdapters.QueriesTableAdapter aInsertDailyTrailerInspectionTableAdapter;

        FindDailyTrailerInspectionByDateRangeDataSet aFindDailyTrailerInspectionByDateRangeDataSet;
        FindDailyTrailerInspectionByDateRangeDataSetTableAdapters.FindDailyTrailerInspectionByDateRangeTableAdapter aFindDailyTrailerInspectionByDateRangeTableAdapter;

        FindDailyTrailerInspectionByEmployeeIDDataSet aFindDailyTrailerInspectionByEmployeeIDDataSet;
        FindDailyTrailerInspectionByEmployeeIDDataSetTableAdapters.FindDailyTrailerInspectionByEmployeeIDTableAdapter aFindDailyTrailerInspectionByEmployeeIDTableAdapter;

        FindDailyTrailerInspectionByTrailerIDDataSet aFindDailyTrailerInspectionByTrailerIDDataSet;
        FindDailyTrailerInspectionByTrailerIDDataSetTableAdapters.FindDailyTrailerInspectionByTrailerIDTableAdapter aFindDailyTrailerInspectionByTrailerIDTableAdapter;

        FindDailyTrailerInspectionByDateMatchDataSet aFindDailyTrailerInspectionByDateMatchDataSet;
        FindDailyTrailerInspectionByDateMatchDataSetTableAdapters.FindDailyTrailerInspectionByDateMatchTableAdapter aFindDailyTrailerInspectionByDateMatchTableAdapter;

        public FindDailyTrailerInspectionByDateMatchDataSet FindDailyTrailerIhnspectionByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindDailyTrailerInspectionByDateMatchDataSet = new FindDailyTrailerInspectionByDateMatchDataSet();
                aFindDailyTrailerInspectionByDateMatchTableAdapter = new FindDailyTrailerInspectionByDateMatchDataSetTableAdapters.FindDailyTrailerInspectionByDateMatchTableAdapter();
                aFindDailyTrailerInspectionByDateMatchTableAdapter.Fill(aFindDailyTrailerInspectionByDateMatchDataSet.FindDailyTrailerInspectionByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Find Daily Trailer Inspection By Date Match " + Ex.Message);
            }

            return aFindDailyTrailerInspectionByDateMatchDataSet;
        }
        public FindDailyTrailerInspectionByTrailerIDDataSet FindDailyTrailerInspectionByTrailerID(int intTrailerID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyTrailerInspectionByTrailerIDDataSet = new FindDailyTrailerInspectionByTrailerIDDataSet();
                aFindDailyTrailerInspectionByTrailerIDTableAdapter = new FindDailyTrailerInspectionByTrailerIDDataSetTableAdapters.FindDailyTrailerInspectionByTrailerIDTableAdapter();
                aFindDailyTrailerInspectionByTrailerIDTableAdapter.Fill(aFindDailyTrailerInspectionByTrailerIDDataSet.FindDailyTrailerInspectionByTrailerID, intTrailerID, datStartDate, datEndDate);

            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Find Daily Trailer Inspection By Trailer ID " + Ex.Message);
            }

            return aFindDailyTrailerInspectionByTrailerIDDataSet;
        }
        public FindDailyTrailerInspectionByEmployeeIDDataSet FindDailyTrailerInspectionByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyTrailerInspectionByEmployeeIDDataSet = new FindDailyTrailerInspectionByEmployeeIDDataSet();
                aFindDailyTrailerInspectionByEmployeeIDTableAdapter = new FindDailyTrailerInspectionByEmployeeIDDataSetTableAdapters.FindDailyTrailerInspectionByEmployeeIDTableAdapter();
                aFindDailyTrailerInspectionByEmployeeIDTableAdapter.Fill(aFindDailyTrailerInspectionByEmployeeIDDataSet.FindDailyTrailerInspectionByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find Daily Trailer Inspection By Employee ID " + Ex.Message);
            }

            return aFindDailyTrailerInspectionByEmployeeIDDataSet;
        }
        public FindDailyTrailerInspectionByDateRangeDataSet FindDailyTrailerInspectionByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyTrailerInspectionByDateRangeDataSet = new FindDailyTrailerInspectionByDateRangeDataSet();
                aFindDailyTrailerInspectionByDateRangeTableAdapter = new FindDailyTrailerInspectionByDateRangeDataSetTableAdapters.FindDailyTrailerInspectionByDateRangeTableAdapter();
                aFindDailyTrailerInspectionByDateRangeTableAdapter.Fill(aFindDailyTrailerInspectionByDateRangeDataSet.FindDailyTrailerInspectionByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Find Daily Trailer Inspection By Date Range " + Ex.Message);
            }

            return aFindDailyTrailerInspectionByDateRangeDataSet;
        }
        public bool InsertDailyTrailerInspection(int intTrailerID, int intEmployeeID, DateTime datTransactionDate, string strInspectionStatus, string strInspectionNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDailyTrailerInspectionTableAdapter = new InsertDailyTrailerInspectionEntryTableAdapters.QueriesTableAdapter();
                aInsertDailyTrailerInspectionTableAdapter.InsertDailyTrailerInspection(intTrailerID, intEmployeeID, datTransactionDate, strInspectionStatus, strInspectionNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Insert Daily Trailer Inspection " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DailyTrailerInspectionDataSet GetDailyTrailerInspectionInfo()
        {
            try
            {
                aDailyTrailerInspectionDataSet = new DailyTrailerInspectionDataSet();
                aDailyTrailerInspectionTableAdapter = new DailyTrailerInspectionDataSetTableAdapters.dailytrailerinspectionTableAdapter();
                aDailyTrailerInspectionTableAdapter.Fill(aDailyTrailerInspectionDataSet.dailytrailerinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Get Daily Trailer Inspection Info " + Ex.Message); 
            }

            return aDailyTrailerInspectionDataSet;
        }
        public void UpdateDailyTrailerInspectionDB(DailyTrailerInspectionDataSet aDailyTrailerInspectionDataSet)
        {
            try
            {
                aDailyTrailerInspectionTableAdapter = new DailyTrailerInspectionDataSetTableAdapters.dailytrailerinspectionTableAdapter();
                aDailyTrailerInspectionTableAdapter.Update(aDailyTrailerInspectionDataSet.dailytrailerinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Trailer Inspection Class // Get Daily Trailer Inspection Info " + Ex.Message);
            }
        }
    }
}
