using System;

namespace TempSensor
{
	public class TempSensor : ITempSensor
	{
		public double _curretTemp = 0;    //Id of sensor
		public event EventHandler<TempEventArg> TempChangedEvent;

		public void OnTempChangedEvent()
		{
			TempChangedEvent?.Invoke(this, new TempEventArg() { temp = _curretTemp });
		}

		public void Update(double inputTemp = -272)
        {
			if(inputTemp <= -273)
            {
				Console.WriteLine("Error below abs. zero");
            }
			else
            {
				_curretTemp = inputTemp;
            }
        }

		public double Read()
        {
			return _curretTemp;
        }

		public void SimulateTempChanged()
        {
			OnTempChangedEvent();
        }

	}

}
