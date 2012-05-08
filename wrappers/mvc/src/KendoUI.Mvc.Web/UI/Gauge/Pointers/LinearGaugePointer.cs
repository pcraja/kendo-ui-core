namespace KendoUI.Mvc.UI
{
    /// <summary>
    /// Represents the gauge pointer
    /// </summary>
    public class LinearGaugePointer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearGaugePointer" /> class.
        /// </summary>
        public LinearGaugePointer()
        {
            Margin = new ChartSpacing();
            Border = new ChartElementBorder();
            Track = new LinearGaugeTrack();
        }

        /// <summary>
        /// Gets or sets the pointer margin
        /// </summary>
        public ChartSpacing Margin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets pointer color
        /// </summary>
        public string Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer border
        /// </summary>
        public ChartElementBorder Border
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer opacity
        /// </summary>
        /// <value>
        /// The pointer opacity
        /// </value>
        public double? Opacity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer shape
        /// </summary>
        /// <value>
        /// The pointer shape
        /// </value>
        public LinearGaugePointerShape? Shape
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer size
        /// </summary>
        /// <value>
        /// The pointer size
        /// </value>
        public double? Size
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer value
        /// </summary>
        /// <value>
        /// The pointer value
        /// </value>
        public double? Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer position
        /// </summary>
        /// <value>
        /// The pointer position
        /// </value>
        public bool? Vertical
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pointer position
        /// </summary>
        /// <value>
        /// The pointer position
        /// </value>
        public LinearGaugeTrack Track
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a serializer
        /// </summary>
        public IChartSerializer CreateSerializer()
        {
            return new LinearGaugePointerSerializer(this);
        }
    }
}