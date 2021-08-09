namespace Interpreter
{
    public class SeparatorExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace(" ", "-");
        }
    }
}
