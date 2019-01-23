using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Infotep_marie
{
    #region Datos_estudiantes
    public class Datos_estudiantes
    {
        #region Member Variables
        protected int _ID;
        protected string _Nombre;
        protected int _Edad;
        #endregion
        #region Constructors
        public Datos_estudiantes() { }
        public Datos_estudiantes(int ID, string Nombre, int Edad)
        {
            this._ID=ID;
            this._Nombre=Nombre;
            this._Edad=Edad;
        }
        #endregion
        #region Public Properties
        public virtual int ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string Nombre
        {
            get {return _Nombre;}
            set {_Nombre=value;}
        }
        public virtual int Edad
        {
            get {return _Edad;}
            set {_Edad=value;}
        }
        #endregion
    }
    #endregion
}