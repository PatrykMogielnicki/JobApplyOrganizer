namespace Domain.ValueObjects
{
    public class Color : ValueObject
    {
        static Color() { }
        private Color() { }
        private Color(string code)
        {
            Code = code;
        }
        private static Color From(string code)
        {
            var color = new Color { Code = code };
            if (!SupportedColor.Contains(color))
            {
                throw new UnsupportedColorException(code);
            }

            return color;
        }

        public static Color White => new("#FFFFFF");
        public static Color Red => new("#FF5733");

        public static Color Orange => new("#FFC300");

        public string Code { get; private set; } = "#000000";

        public static implicit operator string(Color color)
        {
            return color.ToString();
        }

        public static explicit operator Color(string code)
        {
            return From(code);
        }

        protected static IEnumerable<Color> SupportedColor
        {
            get
            {
                yield return White;
                yield return Red;
                yield return Orange;
            }
        }
        protected override IEnumerable<object> GetEqualitycomponents()
        {
            yield return Code;
        }
    }
}
