using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrClusterConfig
{
    public class Viewport : ConfigItem, IDataErrorInfo
    {
        public string id { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string winX { get; set; }
        public string winY { get; set; }
        public string winWidth { get; set; }
        public string winHeight { get; set; }
        public bool horizontalFlip { get; set; }
        public bool verticalFlip { get; set; }

        public Viewport()
        {
            id = "ViewportId";
            x = "0";
            y = "0";
            width = "0";
            height = "0";
            winX = "0";
            winY = "0";
            winWidth = "0";
            winHeight = "0";
            horizontalFlip = false;
            verticalFlip = false;
        }

        public Viewport(string _id, string _x, string _y, string _width, string _height, string _winX, string _winY, string _winWidth, string _winHeight, bool _horizontalFlip, bool _verticalFlip)
        {
            id = _id;
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            winX = _winX;
            winY = _winY;
            winWidth = _winWidth;
            winHeight = _winHeight;
            horizontalFlip = _horizontalFlip;
            verticalFlip = _verticalFlip;
        }

        //Implementation IDataErrorInfo methods for validation
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                if (columnName == "id" || columnName == validationName)
                {
                    if (!ValidationRules.IsName(id))
                    {
                        error = "Viewport ID should contain only letters, numbers and _";
                        AppLogger.Add("ERROR! " + error);
                    }
                }
                if (columnName == "x" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(x.ToString()))
                    {
                        error = "x should be an integer";
                        AppLogger.Add("ERROR! " + error);
                    }
                }
                if (columnName == "y" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(y.ToString()))
                    {
                        error = "y should be an integer";
                        AppLogger.Add("ERROR! " + error);
                    }
                }
                if (columnName == "width" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(width.ToString()) || Convert.ToInt32(width) < 0)
                    {
                        error = "Width should be an integer";
                        AppLogger.Add("ERROR! " + error);
                    }
                }
                if (columnName == "height" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(height.ToString()) || Convert.ToInt32(height) < 0)
                    {
                        error = "Height should be an integer";
                        AppLogger.Add("ERROR! " + error);
                    }
                }
                if (columnName == "winX" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(winX.ToString()))
                    {
                        error = "winX should be an integer";
                        AppLogger.Add("Error! " + error);
                    }
                }
                if (columnName == "winY" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(winY.ToString()))
                    {
                        error = "winY should be an integer";
                        AppLogger.Add("Error! " + error);
                    }
                }
                if (columnName == "winWidth" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(winWidth.ToString()) || Convert.ToInt32(winWidth) < 0)
                    {
                        error = "winWidth should be a integer (>= 0)";
                        AppLogger.Add("Error! " + error);
                    }
                }
                if (columnName == "winHeight" || columnName == validationName)
                {
                    if (!ValidationRules.IsInt(winHeight.ToString()) || Convert.ToInt32(winHeight) < 0)
                    {
                        error = "winHeight should be a integer (>= 0)";
                        AppLogger.Add("Error! " + error);
                    }
                }
                //switch (columnName)
                //{
                //    case "id":
                //        if (!ValidationRules.IsName(id))
                //        {
                //            error = "Viewport ID should contain only letters, numbers and _";
                //        }
                //        break;
                //    case "x":
                //        if (!ValidationRules.IsInt(x.ToString()))
                //        {
                //            error = "x should be an integer";
                //        }
                //        break;
                //    case "y":
                //        if (!ValidationRules.IsInt(y.ToString()))
                //        {
                //            error = "y should be an integer";
                //        }
                //        break;
                //    case "width":
                //        if (!ValidationRules.IsInt(width.ToString()))
                //        {
                //            error = "Width should be an integer";
                //        }
                //        break;
                //    case "height":
                //        if (!ValidationRules.IsInt(height.ToString()))
                //        {
                //            error = "Height should be an integer";
                //        }
                //        break;
                //}
                //if (!string.IsNullOrEmpty(error))
                //{
                //    AppLogger.Add("ERROR! " + error);
                //}
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Validate()
        {
            bool isValid = ValidationRules.IsName(id) && ValidationRules.IsInt(x.ToString()) && ValidationRules.IsInt(y.ToString()) 
                && (ValidationRules.IsInt(width.ToString()) || Convert.ToInt32(width) > 0) && (ValidationRules.IsInt(height.ToString()) || Convert.ToInt32(height) > 0)
                && ValidationRules.IsInt(winX) && ValidationRules.IsInt(winY)
                && (ValidationRules.IsInt(winWidth) && Convert.ToInt32(winWidth) >= 0)
                && (ValidationRules.IsInt(winHeight) && Convert.ToInt32(winHeight) >= 0);
            if (!isValid)
            {
                AppLogger.Add("ERROR! Errors in Viewport [" + id + "]");
                string a = this[validationName];

            }

            return isValid;
        }

        public override string CreateCfg()
        {
            string stringCfg = "[viewport] ";
            stringCfg = string.Concat(stringCfg, "id=", id, " loc=\"X=", x, ",Y=", y, "\" size=\"X=", width, ",Y=", height,
                "\" win_loc=\"X=", winX, ",Y=", winY, "\" win_size=\"X=", winWidth, ",Y=", winHeight,
                "\" flip_h=", horizontalFlip.ToString(), " flip_v=", verticalFlip, "\n");

            return stringCfg;
        }
    }
}
