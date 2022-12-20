using System;
using System.Collections.Generic;

namespace RiverObserver{
    public class River : EventArgs{
        
        private string _name;
        private int _level;
        
        List<Ship> ShipRegistry = new List<Ship>();
        
        public event EventHandler<River> SensorLevelAlarm_;
        
        public River(string inp_name, int inp_level){
            this._name = inp_name;
            _SetLevel(inp_level); 
        }
        
        public int _GetLevel(){ 
            return this._level; 
        }
        public void _SetLevel(int value){
            this._level = (value < 100) ? 100 : ((value > 10000) ? 10000 : value);
            LEVELCHANGED();
        }
        
        public void _ShipCheckIn(Ship inpShip){
            ShipRegistry.Add(inpShip);
            SensorLevelAlarm_ += inpShip._OnLevelChanged;
        }
        
        public void _ShipCheckOut(string ship_name, River _TargetRiver){
            foreach (var ship in ShipRegistry){
                if (ship._GetName() == ship_name){
                    _TargetRiver._ShipCheckIn(ship);
                    ShipRegistry.Remove(ship);
                }
                else{
                    Console.WriteLine("DEBUG MSG::SHIP NOT FOUND || <= RIVER.CS");
                }
            }
        }
        
        public void LEVELCHANGED(){
            SensorLevelAlarm_(this, this);
        }
    }
}
