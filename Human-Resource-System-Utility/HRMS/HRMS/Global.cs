using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    static class Global
    {
        private static int _globalVar1;

        public static int GlobalVar1 //GLOBAL VARIABLE FOR ID
        {
            get { return _globalVar1; }
            set { _globalVar1 = value; }
        }

        private static string _globalVar2 = "";

        public static string GlobalVar2 //GLOBAL VARIABLE FOR LAST_NAME
        {
            get { return _globalVar2; }
            set { _globalVar2 = value; }
        }

        private static string _globalVar3 = ""; //GLOBAL VARIABLE FOR FIRST_NAME

        public static string GlobalVar3
        {
            get { return _globalVar3; }
            set { _globalVar3 = value; }
        }

        private static string _globalVar4 = ""; //GLOBAL VARIABLE FOR MIDDLE

        public static string GlobalVar4
        {
            get { return _globalVar4; }
            set { _globalVar4 = value; }
        }

        private static string _globalVar5 = ""; //GLOBAL VARIABLE FOR SUFFIX

        public static string GlobalVar5
        {
            get { return _globalVar5; }
            set { _globalVar5 = value; }
        }

        private static string _globalVar6 = ""; //GLOBAL VARIABLE FOR DESIGNATION

        public static string GlobalVar6
        {
            get { return _globalVar6; }
            set { _globalVar6 = value; }
        }

        private static string _globalVar7 = ""; //GLOBAL VARIABLE FOR TOKEN

        public static string GlobalVar7
        {
            get { return _globalVar7; }
            set { _globalVar7 = value; }
        }

        private static int _globalVar8; //GLOBAL VARIABLE FOR ID_ASSOC FOR DATAGRIDS

        public static int GlobalVar8
        {
            get { return _globalVar8; }
            set { _globalVar8 = value; }
        }

        private static string _globalVar9 = ""; //GLOBAL VARIABLE SCHOOL NAME

        public static string GlobalVar9
        {
            get { return _globalVar9; }
            set { _globalVar9 = value; }
        }

        private static string _globalVar10 = ""; //GLOBAL VARIABLE DESIGNATION

        public static string GlobalVar10
        {
            get { return _globalVar10; }
            set { _globalVar10 = value; }
        }
    }
}
