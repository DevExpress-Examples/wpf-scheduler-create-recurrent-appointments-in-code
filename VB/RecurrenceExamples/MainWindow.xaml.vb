Imports DevExpress.Xpf.Scheduling
Imports DevExpress.XtraScheduler
Imports System.Windows

Namespace RecurrenceExamples

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            'CreateMinutelyRecurrence();
            'CreateHourlyRecurrence();
            CreateDailyRecurrence()
            CreateWeeklyRecurrence()
            CreateMonthlyRecurrence()
            CreateYearlyRecurrence()
        End Sub

#Region "#pattern"
        Public Function CreateAppointmentPattern(ByVal subj As String, ByVal categoryId As Integer) As AppointmentItem
            Dim apt As AppointmentItem = New AppointmentItem(AppointmentType.Pattern)
            apt.Start = Date.Today.AddHours(9)
            apt.End = apt.Start.AddMinutes(5)
            apt.Subject = subj
            apt.LabelId = categoryId
            Return apt
        End Function

#End Region  ' #pattern
        Public Sub CreateMinutelyRecurrence()
#Region "#minutely"
            ' An appointment is set every 10 minutes. Five occurrences.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("Every 10 minutes. Five occurrences.", 0)
            apt1.RecurrenceInfo.Type = RecurrenceType.Minutely
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.Periodicity = 10
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 5
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment is set every 45 minutes. Infinite (no end time).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("Every 45 minutes. Infinite", 0)
            apt2.RecurrenceInfo.Type = RecurrenceType.Minutely
            apt2.RecurrenceInfo.Start = apt1.Start
            apt2.RecurrenceInfo.Periodicity = 45
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment is set every 20 minutes. The appointment chain duration is 10 hours.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("Every 20 minutes. Series duration is 10 hours.", 0)
            apt3.RecurrenceInfo.Type = RecurrenceType.Minutely
            apt3.RecurrenceInfo.Start = apt1.Start
            apt3.RecurrenceInfo.Periodicity = 20
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt1.RecurrenceInfo.Start.AddHours(10)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #minutely
        End Sub

        Public Sub CreateHourlyRecurrence()
#Region "#hourly"
            ' An appointment is set every 3 hours. Five occurrences.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("Every 3 hours. Five occurrences.", 1)
            apt1.RecurrenceInfo.Type = RecurrenceType.Hourly
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.Periodicity = 3
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 5
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment is set every 5 hours. Infinite (no end date).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("Every 5 hours. Infinite (no end date).", 1)
            apt2.RecurrenceInfo.Type = RecurrenceType.Hourly
            apt2.RecurrenceInfo.Start = apt2.Start
            apt2.RecurrenceInfo.Periodicity = 5
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment is set every hour. Appointment series duration is 24 hours.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("Every hour.  Series duration is 24 hours.", 1)
            apt3.RecurrenceInfo.Type = RecurrenceType.Hourly
            apt3.RecurrenceInfo.Start = apt3.Start
            apt3.RecurrenceInfo.Periodicity = 1
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddHours(24)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #hourly
        End Sub

        Public Sub CreateDailyRecurrence()
#Region "#daily"
            ' An appointment is set every 3 days. Five occurrences.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("Every 3 days. Five occurrences.", 2)
            apt1.RecurrenceInfo.Type = RecurrenceType.Daily
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.Periodicity = 3
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 5
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment is set every day. Infinite (no end date).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("Every day. Infinite (no end date).", 2)
            apt2.RecurrenceInfo.Type = RecurrenceType.Daily
            apt2.RecurrenceInfo.Start = apt2.Start
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment occurs every five days. Appointments are set for one month.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("Every 5 days. Series for one month.", 2)
            apt3.RecurrenceInfo.Type = RecurrenceType.Daily
            apt3.RecurrenceInfo.Start = apt3.Start
            apt3.RecurrenceInfo.Periodicity = 5
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddMonths(1)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #daily
        End Sub

        Public Sub CreateWeeklyRecurrence()
#Region "#weekly"
            ' An appointment recurs every 2 weeks, on Monday and Wednesday. It occurs 15 times.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("Every 2 weeks, on Monday and Wednesday, 15 times.", 3)
            apt1.RecurrenceInfo.Type = RecurrenceType.Weekly
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.Periodicity = 2
            apt1.RecurrenceInfo.WeekDays = WeekDays.Monday Or WeekDays.Wednesday
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 15
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment occurs every fourth week on weekends. Infinite (no end date).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("Every fourth week on weekends. Infinite (no end date).", 3)
            apt2.RecurrenceInfo.Type = RecurrenceType.Weekly
            apt2.RecurrenceInfo.Start = apt2.Start
            apt2.RecurrenceInfo.Periodicity = 4
            apt2.RecurrenceInfo.WeekDays = WeekDays.WeekendDays
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment occurs every Friday for 24 days.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("Every Friday for 24 days.", 3)
            apt3.RecurrenceInfo.Type = RecurrenceType.Weekly
            apt3.RecurrenceInfo.Start = apt3.Start
            apt3.RecurrenceInfo.Periodicity = 1
            apt3.RecurrenceInfo.WeekDays = WeekDays.Friday
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddDays(24)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #weekly
        End Sub

        Public Sub CreateMonthlyRecurrence()
#Region "#monthly"
            ' An appointment occurs on the 11th day of each month. Four occurrences.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("On 11th day of each month. Four occurrences.", 4)
            apt1.RecurrenceInfo.Type = RecurrenceType.Monthly
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.DayNumber = 11
            apt1.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 4
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment occurs on the last Wednesday of the month, for 2 months. Infinite (no end date).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("Last Wednesday of the month, for 2 months. Infinite (no end date).", 4)
            apt2.RecurrenceInfo.Type = RecurrenceType.Monthly
            apt2.RecurrenceInfo.Periodicity = 2
            apt2.RecurrenceInfo.Start = apt2.Start
            apt2.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Last
            apt2.RecurrenceInfo.WeekDays = WeekDays.Wednesday
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment occurs on the first Monday of the month for 3 months. The series duration is one year.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("First Monday of the month for 3 months. The series duration is one year.", 4)
            apt3.RecurrenceInfo.Type = RecurrenceType.Monthly
            apt3.RecurrenceInfo.Periodicity = 3
            apt3.RecurrenceInfo.Start = apt3.Start
            apt3.RecurrenceInfo.WeekOfMonth = WeekOfMonth.First
            apt3.RecurrenceInfo.WeekDays = WeekDays.Monday
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddYears(1)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #monthly
        End Sub

        Public Sub CreateYearlyRecurrence()
#Region "#yearly"
            ' An appointment occurs every seventh day of February every year. Four occurrences.
            Dim apt1 As AppointmentItem = CreateAppointmentPattern("Every seventh day of February every year. Four occurrences.", 5)
            apt1.RecurrenceInfo.Type = RecurrenceType.Yearly
            apt1.RecurrenceInfo.Periodicity = 1
            apt1.RecurrenceInfo.Start = apt1.Start
            apt1.RecurrenceInfo.Month = 2
            apt1.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None
            apt1.RecurrenceInfo.DayNumber = 7
            apt1.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            apt1.RecurrenceInfo.OccurrenceCount = 4
            Me.scheduler.AppointmentItems.Add(apt1)
            ' An appointment occurs the second Monday in August for 2 years. Infinite (no end date).
            Dim apt2 As AppointmentItem = CreateAppointmentPattern("The second Monday in August for 2 years. Infinite (no end date).", 5)
            apt2.RecurrenceInfo.Type = RecurrenceType.Yearly
            apt2.RecurrenceInfo.Periodicity = 2
            apt2.RecurrenceInfo.Start = apt2.Start
            apt2.RecurrenceInfo.Month = 8
            apt2.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Second
            apt2.RecurrenceInfo.WeekDays = WeekDays.Monday
            apt2.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
            Me.scheduler.AppointmentItems.Add(apt2)
            ' An appointment occurs on the last day of every year for 10 years.
            Dim apt3 As AppointmentItem = CreateAppointmentPattern("The last day of every year for 10 years.", 5)
            apt3.RecurrenceInfo.Type = RecurrenceType.Yearly
            apt3.RecurrenceInfo.Periodicity = 1
            apt3.RecurrenceInfo.Start = apt3.Start
            apt3.RecurrenceInfo.Month = 12
            apt3.RecurrenceInfo.WeekOfMonth = WeekOfMonth.Last
            apt3.RecurrenceInfo.WeekDays = WeekDays.EveryDay
            apt3.RecurrenceInfo.Range = RecurrenceRange.EndByDate
            apt3.RecurrenceInfo.End = apt3.RecurrenceInfo.Start.AddYears(10)
            Me.scheduler.AppointmentItems.Add(apt3)
#End Region  ' #yearly
        End Sub
    End Class
End Namespace
