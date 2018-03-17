using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Doctors.Models;

namespace Doctors.Views
{
    public class SchedulerController : Controller
    {
        // GET: Scheduler
        public ActionResult SchedulerView()
        {
            return View(SchedulerDataHelper.DataObject);
        }
        public ActionResult SchedulerPartial()
        {
            return PartialView("_SchedulerPartial", SchedulerDataHelper.DataObject);
        }

        public ActionResult EditAppointment()
        {
            UpdateAppointment();
            return PartialView("_SchedulerPartial", SchedulerDataHelper.DataObject);
        }

        #region #updateappointment

        static void UpdateAppointment()
        {
            EFAppointment insertedAppt = SchedulerExtension.GetAppointmentToInsert<EFAppointment>(
                SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            SchedulerDataHelper.InsertAppointment(insertedAppt);

            EFAppointment[] updatedAppt = SchedulerExtension.GetAppointmentsToUpdate<EFAppointment>(
                SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            foreach (var appt in updatedAppt)
            {
                SchedulerDataHelper.UpdateAppointment(appt);
            }

            EFAppointment[] removedAppt = SchedulerExtension.GetAppointmentsToRemove<EFAppointment>(
                SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            foreach (var appt in removedAppt)
            {
                SchedulerDataHelper.RemoveAppointment(appt);
            }

        }

        #endregion #updateappointment
    }
}