using System;

namespace RiverObserver{
    public class Ship{
        
        private string _name;
        private int    _currLevel;
        private bool   _voyage;
        
        private _Threshhold _Levels;
        private River _River;

        public Ship(string inp_name, River inpRiver){
            _Threshhold inpLevels = new _Threshhold(250,8000);
            this._name      = inp_name;
            this._currLevel = inpRiver._GetLevel();
            this._Levels    = inpLevels;
            this._River     = inpRiver;
        }
       
        public virtual void _OnLevelChanged(object sender, River _River){
            if (_River._GetLevel() < 250 || _River._GetLevel() > 8000){ 
                this._voyage = false;
            }
            else{
                this._voyage = true;
            }
            this._currLevel = _River._GetLevel();
        }
        
        public bool _GetVoyage(){
        return _voyage;
        }
        
        public void _SetRiver(River inpRiver){
            this._River = inpRiver;
        }
        public River _GetRiver(){
            return this._River;
        }
        
        public string _GetName(){
            return this._name;
        }
        
        struct _Threshhold{
            public int _min;
            public int _max;
            
            public _Threshhold(int min, int max){
                this._min = min;
                this._max = max;   
            }   
        }   
    }    
}
