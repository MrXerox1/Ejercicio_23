﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_Robado
{
    public class Dolar
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        public static void SetCotizacion(double cotizacion)
        {
            Dolar.cotizRespectoDolar = cotizacion;

        }
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euros(Dolar d)
        {
            return new Euros(d.cantidad * Euros.GetCotizacion());
        }
        #endregion

        #region Operaciones
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return aux;
        }

        public static Dolar operator +(Dolar d, Euros e)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return aux;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }

        public static Dolar operator -(Dolar d, Euros e)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return aux;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euros e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euros e)
        {
            return !(d == e);
        }
        #endregion
    }
}