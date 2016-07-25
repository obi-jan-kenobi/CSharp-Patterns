﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer {
    class Weatherdata : ISubject {
        private List<IObserver> observers;

        private float temperature;
        private float humidity;
        private float pressure;

        public Weatherdata() {
            observers = new List<IObserver>();
        }

        public void notifyObservers() {
            foreach (IObserver o in observers) {
                o.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o) {
            observers.Add(o);
        }

        public void removeObserver(IObserver o) {
            observers.Remove(o);
        }

        public void measurementsChanged() {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
