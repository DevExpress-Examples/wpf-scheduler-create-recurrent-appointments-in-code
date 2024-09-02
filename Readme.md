<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655822/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T574486)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Scheduler - Create Recurrent Appointments in Code

This example demonstrates how to create scheduler appointments with different recurrence types in code. To create a recurring series, set the [AppointmentItem.Type](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.AppointmentItem.Type) property to `Pattern` and use the [AppointmentItem.RecurrenceInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerItemBase.RecurrenceInfo) property to define a recurrence pattern. The scheduler generates occurrences based on this pattern.

## Files to Review

* [MainWindow.xaml](./CS/RecurrenceExamples/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/RecurrenceExamples/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RecurrenceExamples/MainWindow.xaml.vb))

## Documentation

* [Recurrences](https://docs.devexpress.com/WPF/119213/controls-and-libraries/scheduler/appointments/recurrence)
* [Create Recurrence in Code](https://docs.devexpress.com/WPF/119648/controls-and-libraries/scheduler/examples/how-to-create-recurrence-in-code)
* [IRecurrenceInfo](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.IRecurrenceInfo)

## More Examples

* [WPF Scheduler - Create Regular and Recurrent Appointments at the View Model Level](https://github.com/DevExpress-Examples/How-to-Create-regular-and-recurrent-appointments-at-the-view-model-level)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-create-recurrent-appointments-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-create-recurrent-appointments-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
