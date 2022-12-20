using System;
using System.Collections.Generic;

namespace RiverObserver{
    public class RiverBox{
        
        private int _width;
        private int _height;
        private int _off_x;
        private int _off_y;
        
        private Box _Header;
        private Box _Body;
        private Box _Meter;
        
        public RiverBox(int width, int height, int offset_x, int offset_y, string headerText){
            this._width  = width;
            this._height = height;
            this._off_x  = offset_x;
            this._off_y  = offset_y;
            this._Header = new Box(_width, 3, _off_x, _off_y);
            this._Body   = new Box(_width, _height, _off_x, _off_y + 3);
            this._Meter  = new Box(3, _height + 3, _off_x + _width + 1, _off_y);
            this._Header._Write(headerText, true);

            _DrawHSep(2, "Ship Registry");
        }
        
        public void _DrawHSep(int ypos, string linetext){
            _Body._Draw_HSeparator(ypos + _off_y + 3);
            Console.SetCursorPosition(_off_x + 1, _off_y + 4);
            Console.WriteLine(linetext);
        }
    }
}
