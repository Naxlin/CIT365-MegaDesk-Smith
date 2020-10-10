using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT365_MegaDesk_Smith
{
    // Enum for the supported desk materials.
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    // Class for the Desk object, contains pertinent desk info.
    public class Desk
    {
        // Constants for the size regulating variables:
        public static int MIN_WIDTH = 24;
        public static int MAX_WIDTH = 96;
        public static int MIN_DEPTH = 12;
        public static int MAX_DEPTH = 48;
        public static int MIN_DRAWERS = 0;
        public static int MAX_DRAWERS = 7;

        // Variables:
        // Size vars:
        public int Width { get; set; }
        public int Depth { get; set; }
        // Drawers:
        public int NumberOfDrawers { get; set; }
        // Material (based off of enum above):
        public DesktopMaterial SurfaceMaterial { get; set; }

    }
}
