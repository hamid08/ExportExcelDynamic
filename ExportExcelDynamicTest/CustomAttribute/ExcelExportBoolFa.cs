namespace ExportExcelDynamicTest.CustomAttribute
{
    public class ExcelExportBoolFa : Attribute
    {
        public ExcelExportBoolFa(string trueValue, string falseValue)
        {
            TrueValue = trueValue;
            FalseValue = falseValue;
        }

        public string TrueValue { get; }
        public string FalseValue { get; }
    }
}
