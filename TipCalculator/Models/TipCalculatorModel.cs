namespace TipCalculator.Models{
    public class TipCalculatorModel
    {
        public decimal? costofmeal { get; set; }
        public decimal? CalculateTip(int percent){ 
            if(costofmeal.HasValue){
                return costofmeal.Value * percent / 100;
            }
            return null;
         }

    }
}