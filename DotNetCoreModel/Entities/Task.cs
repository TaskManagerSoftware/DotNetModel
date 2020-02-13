﻿using System;
using System.Collections.Generic;

namespace DotNetCoreModel.Entities
{
    public class Task : AuditableEntityBase
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public bool IsMyDay { get; set; }
        public bool IsImportant { get; set; }
        public DateTime? RemindDateUTC { get; set; }
        public DateTime? DueDateUTC { get; set; }
        public RepeatType RepeatType { get; set; }
        public byte? SelectedWeekDays { get; set; }
        public string Note { get; set; }
        public IList<TaskContributor> Accounts { get; set; }
        public IList<Step> Steps { get; set; }
        public IList<Attachment> Attachments { get; set; }
    }

    public enum RepeatType
    {
        Never = 0,
        Daily = 1,
        WeekDays = 2,
        Weekly = 3,
        Monthly = 4,
        Yearly = 5
    }
}