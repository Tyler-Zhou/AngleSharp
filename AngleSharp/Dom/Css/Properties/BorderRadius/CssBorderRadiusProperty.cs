﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/border-radius
    /// </summary>
    sealed class CssBorderRadiusProperty : CssShorthandProperty
    {
        #region Fields

        static readonly IValueConverter StyleConverter = Converters.WithOrder(
            Converters.LengthOrPercentConverter.Periodic(
                PropertyNames.BorderTopLeftRadius, PropertyNames.BorderTopRightRadius, PropertyNames.BorderBottomRightRadius, PropertyNames.BorderBottomLeftRadius).Required(),
            Converters.LengthOrPercentConverter.Periodic(
                PropertyNames.BorderTopLeftRadius, PropertyNames.BorderTopRightRadius, PropertyNames.BorderBottomRightRadius, PropertyNames.BorderBottomLeftRadius).
            StartsWithDelimiter().Option()).OrDefault();

        #endregion

        #region ctor

        internal CssBorderRadiusProperty()
            : base(PropertyNames.BorderRadius, PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion
    }
}
