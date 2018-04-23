using DevExpress.Xpf.Scheduling;
using DevExpress.XtraScheduler;
using System;
using System.Windows;

namespace RecurrenceExamples {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();

            //CreateMinutelyRecurrence();
            //CreateHourlyRecurrence();
            CreateDailyRecurrence();
            CreateWeeklyRecurrence();
            CreateMonthlyRecurrence();
            CreateYearlyRecurrence();
        }

        #region #pattern
        public AppointmentItem CreateAppointmentPattern(string subj, int categoryId) {
            AppointmentItem apt = new AppointmentItem(AppointmentType.Pattern);
            apt.Start = DateTime.Today.AddHours(9);
            apt.End = apt.Start.AddMinutes(5);
            apt.Subject = subj;
            apt.LabelId = categoryId;
            return apt;
        }
        #endregion #pattern

        public void CreateMinutelyRecurrence() {
            #region #minutely
            // An appointment is set every 10 minutes. Five occurrences.
            AppointmentItem apt1 = CreateAppointmentPattern("Every 10 minutes. Five occurrences.", 0);
            apt1.RecurrenceInfo.Type = RecurrenceType.Minutely;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.Periodicity = 10;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 5;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment is set every 45 minutes. Infinite (no end time).
            AppointmentItem apt2 = CreateAppointmentPattern("Every 45 minutes. Infinite", 0);
            apt2.RecurrenceInfo.Type = RecurrenceType.Minutely;
            apt2.RecurrenceInfo.Start = apt1.Start;
            apt2.RecurrenceInfo.Periodicity = 45;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment is set every 20 minutes. The appointment chain duration is 10 hours.
            AppointmentItem apt3 = CreateAppointmentPattern("Every 20 minutes. Series duration is 10 hours.", 0);
            apt3.RecurrenceInfo.Type = RecurrenceType.Minutely;
            apt3.RecurrenceInfo.Start = apt1.Start;
            apt3.RecurrenceInfo.Periodicity = 20;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt1.RecurrenceInfo.Start.AddHours(10);
            scheduler.AppointmentItems.Add(apt3);
            #endregion #minutely
        }
        public void CreateHourlyRecurrence() {
            #region #hourly
            // An appointment is set every 3 hours. Five occurrences.
            AppointmentItem apt1 = CreateAppointmentPattern("Every 3 hours. Five occurrences.", 1);
            apt1.RecurrenceInfo.Type = RecurrenceType.Hourly;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.Periodicity = 3;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 5;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment is set every 5 hours. Infinite (no end date).
            AppointmentItem apt2 = CreateAppointmentPattern("Every 5 hours. Infinite (no end date).", 1);
            apt2.RecurrenceInfo.Type = RecurrenceType.Hourly;
            apt2.RecurrenceInfo.Start = apt2.Start;
            apt2.RecurrenceInfo.Periodicity = 5;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment is set every hour. Appointment series duration is 24 hours.
            AppointmentItem apt3 = CreateAppointmentPattern("Every hour.  Series duration is 24 hours.", 1);
            apt3.RecurrenceInfo.Type = RecurrenceType.Hourly;
            apt3.RecurrenceInfo.Start = apt3.Start;
            apt3.RecurrenceInfo.Periodicity = 1;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddHours(24);
            scheduler.AppointmentItems.Add(apt3);
            #endregion #hourly
        }
        public void CreateDailyRecurrence() {
            #region #daily
            // An appointment is set every 3 days. Five occurrences.
            AppointmentItem apt1 = CreateAppointmentPattern("Every 3 days. Five occurrences.", 2);
            apt1.RecurrenceInfo.Type = RecurrenceType.Daily;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.Periodicity = 3;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 5;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment is set every day. Infinite (no end date).
            AppointmentItem apt2 = CreateAppointmentPattern("Every day. Infinite (no end date).", 2);
            apt2.RecurrenceInfo.Type = RecurrenceType.Daily;
            apt2.RecurrenceInfo.Start = apt2.Start;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment occurs every five days. Appointments are set for one month.
            AppointmentItem apt3 = CreateAppointmentPattern("Every 5 days. Series for one month.", 2);
            apt3.RecurrenceInfo.Type = RecurrenceType.Daily;
            apt3.RecurrenceInfo.Start = apt3.Start;
            apt3.RecurrenceInfo.Periodicity = 5;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddMonths(1);
            scheduler.AppointmentItems.Add(apt3);
            #endregion #daily
        }

        public void CreateWeeklyRecurrence() {
            #region #weekly
            // An appointment recurs every 2 weeks, on Monday and Wednesday. It occurs 15 times.
            AppointmentItem apt1 = CreateAppointmentPattern("Every 2 weeks, on Monday and Wednesday, 15 times.", 3);
            apt1.RecurrenceInfo.Type = RecurrenceType.Weekly;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.Periodicity = 2;
            apt1.RecurrenceInfo.WeekDays = WeekDays.Monday | WeekDays.Wednesday;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 15;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment occurs every fourth week on weekends. Infinite (no end date).
            AppointmentItem apt2 = CreateAppointmentPattern("Every fourth week on weekends. Infinite (no end date).", 3);
            apt2.RecurrenceInfo.Type = RecurrenceType.Weekly;
            apt2.RecurrenceInfo.Start = apt2.Start;
            apt2.RecurrenceInfo.Periodicity = 4;
            apt2.RecurrenceInfo.WeekDays = WeekDays.WeekendDays;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment occurs every Friday for 24 days.
            AppointmentItem apt3 = CreateAppointmentPattern("Every Friday for 24 days.", 3);
            apt3.RecurrenceInfo.Type = RecurrenceType.Weekly;
            apt3.RecurrenceInfo.Start = apt3.Start;
            apt3.RecurrenceInfo.Periodicity = 1;
            apt3.RecurrenceInfo.WeekDays = WeekDays.Friday;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddDays(24);

            scheduler.AppointmentItems.Add(apt3);
            #endregion #weekly
        }

        public void CreateMonthlyRecurrence() {
            #region #monthly
            // An appointment occurs on the 11th day of each month. Four occurrences.
            AppointmentItem apt1 = CreateAppointmentPattern("On 11th day of each month. Four occurrences.", 4);
            apt1.RecurrenceInfo.Type = RecurrenceType.Monthly;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.DayNumber = 11;
            apt1.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 4;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment occurs on the last Wednesday of the month, for 2 months. Infinite (no end date).
            AppointmentItem apt2 = CreateAppointmentPattern("Last Wednesday of the month, for 2 months. Infinite (no end date).", 4);
            apt2.RecurrenceInfo.Type = RecurrenceType.Monthly;
            apt2.RecurrenceInfo.Periodicity = 2;
            apt2.RecurrenceInfo.Start = apt2.Start;
            apt2.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Last;
            apt2.RecurrenceInfo.WeekDays = WeekDays.Wednesday;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment occurs on the first Monday of the month for 3 months. The series duration is one year.
            AppointmentItem apt3 = CreateAppointmentPattern("First Monday of the month for 3 months. The series duration is one year.", 4);
            apt3.RecurrenceInfo.Type = RecurrenceType.Monthly;
            apt3.RecurrenceInfo.Periodicity = 3;
            apt3.RecurrenceInfo.Start = apt3.Start;
            apt3.RecurrenceInfo.WeekOfMonth = WeekOfMonth.First;
            apt3.RecurrenceInfo.WeekDays = WeekDays.Monday;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddYears(1);
            scheduler.AppointmentItems.Add(apt3);
            #endregion #monthly
        }

        public void CreateYearlyRecurrence() {
            #region #yearly
            // An appointment occurs every seventh day of February every year. Four occurrences.
            AppointmentItem apt1 = CreateAppointmentPattern("Every seventh day of February every year. Four occurrences.", 5);
            apt1.RecurrenceInfo.Type = RecurrenceType.Yearly;
            apt1.RecurrenceInfo.Periodicity = 1;
            apt1.RecurrenceInfo.Start = apt1.Start;
            apt1.RecurrenceInfo.Month = 2;
            apt1.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None;
            apt1.RecurrenceInfo.DayNumber = 7;
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt1.RecurrenceInfo.OccurrenceCount = 4;
            scheduler.AppointmentItems.Add(apt1);

            // An appointment occurs the second Monday in August for 2 years. Infinite (no end date).
            AppointmentItem apt2 = CreateAppointmentPattern("The second Monday in August for 2 years. Infinite (no end date).", 5);
            apt2.RecurrenceInfo.Type = RecurrenceType.Yearly;
            apt2.RecurrenceInfo.Periodicity = 2;
            apt2.RecurrenceInfo.Start = apt2.Start;
            apt2.RecurrenceInfo.Month = 8;
            apt2.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Second;
            apt2.RecurrenceInfo.WeekDays = WeekDays.Monday;
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
            scheduler.AppointmentItems.Add(apt2);

            // An appointment occurs on the last day of every year for 10 years.
            AppointmentItem apt3 = CreateAppointmentPattern("The last day of every year for 10 years.", 5);
            apt3.RecurrenceInfo.Type = RecurrenceType.Yearly;
            apt3.RecurrenceInfo.Periodicity = 1;
            apt3.RecurrenceInfo.Start = apt3.Start;
            apt3.RecurrenceInfo.Month = 12;
            apt3.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Last;
            apt3.RecurrenceInfo.WeekDays = WeekDays.EveryDay;
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddYears(10);
            scheduler.AppointmentItems.Add(apt3);
            #endregion #yearly
        }
    }
}
