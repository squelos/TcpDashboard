﻿using System;
using GalaSoft.MvvmLight;
using TcpDataModel;

namespace Dashboard.Business
{
    public class CourtBookings : ViewModelBase
    {
        #region privates

        private WeeklyBookings _selectedWeeklyBookings;
        private Court _court;
        private DateTime _selectedDay;
        private DateTime _firstDayOfWeek;
        private DateTime _lastDayOfWeek;
        private bool _weekMode = true;

        #endregion

        #region ctor

        public CourtBookings(Court court)
        {
            _court = court;
        }
        #endregion

        #region getters/setters
         

        public Court Court
        {
            get { return _court; }
        }

        public DateTime SelectedDay
        {
            get { return _selectedDay; }
            set
            {
                _selectedDay = value;
                RaisePropertyChanged("SelectedDate");
            }
        }

        #endregion

        #region private Methods

        #endregion


        #region publics

        #endregion
    }
}
