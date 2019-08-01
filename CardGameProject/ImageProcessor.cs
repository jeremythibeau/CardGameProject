using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardGameProject
{
    class ImageProcessor
    {
        public ImageProcessor()
        {
        }

        public Bitmap GetImageByName(string imgName)
        {
            //aligning with filename
            imgName = "_" + imgName;
            //takes a string name and returns the image resource matching the name
            //found on stackOverflow -- https://stackoverflow.com/questions/1192054/load-image-from-resources-area-of-project-in-c-sharp
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imgName);
        }
    }
}
