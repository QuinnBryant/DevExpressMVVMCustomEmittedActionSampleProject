
using System;
using System.ComponentModel;

namespace PropertyGridSample.ViewModels
{

    /// <summary>
    /// Demo for our custom Unit type.
    /// </summary>
    public class Unit : IUnit, IConvertible
    {
        /// <summary>
        /// Occurs when the value is changed.
        /// </summary>
        public event EventHandler<UnitValueChangedEventArgs> ValueChanged;

        private double? _value;

        /// <summary>
        /// Gets or sets the value of the unit.
        /// </summary>
        public double? Value
        {
            get { return _value; }
            set
            {
                double? oldValue = _value;
                _value = value;

                ValueChanged?.Invoke(this, new UnitValueChangedEventArgs(oldValue, _value));
            }
        }

        /// <summary>
        /// Gets or Sets a string representing the unit symbol (ex. "meters" or "inches")
        /// </summary>
        public string Symbol { get; set; }

        public Unit(string symbol)
        {
            Value = 0;
            Symbol = symbol;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Double.</returns>
        private double GetValue(int defaultValue)
        {
            return this.Value ?? defaultValue;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToString(string format, IFormatProvider provider)
        {
            return this.Value.GetValueOrDefault(0).ToString(format, provider) + this.Symbol;
        }

        #region IConvertible

        /// <summary>
        /// Returns the <see cref="T:System.TypeCode" /> for this instance.
        /// </summary>
        /// <returns>
        /// The enumerated constant that is the <see cref="T:System.TypeCode" /> of the class or value type that implements this interface.
        /// </returns>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A Boolean value equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A Unicode character equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public char ToChar(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public byte ToByte(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 16-bit signed integer equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public short ToInt16(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 16-bit unsigned integer equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 32-bit signed integer equivalent to the value of this instance.</returns>
        public int ToInt32(IFormatProvider provider)
        {
            return (int)GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 32-bit unsigned integer equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 64-bit signed integer equivalent to the value of this instance.</returns>
        public long ToInt64(IFormatProvider provider)
        {
            return (long)GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific
        /// formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>An 64-bit unsigned integer equivalent to the value of this instance.</returns>
        public ulong ToUInt64(IFormatProvider provider)
        {
            return (ulong)GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent single-precision floating-point number using the specified
        /// culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
        public float ToSingle(IFormatProvider provider)
        {
            return (float)GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent double-precision floating-point number using the specified
        /// culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
        public double ToDouble(IFormatProvider provider)
        {
            return GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified
        /// culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.</returns>
        public decimal ToDecimal(IFormatProvider provider)
        {
            return (decimal)GetValue(0);
        }

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified
        /// culture-specific formatting information.
        /// </summary>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.</returns>
        /// <exception cref="NotSupportedException">NotSupported</exception>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToString(IFormatProvider provider)
        {
            return ToString("#0.#######", provider);
        }

        /// <summary>
        /// Converts the value of this instance to an <see cref="T:System.Object" /> of the specified <see cref="T:System.Type" />
        /// that has an equivalent value, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted.</param>
        /// <param name="provider">
        /// An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information.
        /// </param>
        /// <returns>
        /// An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to the
        /// value of this instance.
        /// </returns>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(string))
            {
                return ToString(provider);
            }

            if (conversionType == typeof(double))
            {
                return ToDouble(provider);
            }

            return null;
        }

        #endregion IConvertible

    }

    public interface IUnit
    {
        event EventHandler<UnitValueChangedEventArgs> ValueChanged;
        double? Value { get; set; }
        string Symbol { get; set; }
    }

    public class UnitValueChangedEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitValueChangedEventArgs" /> class.
        /// </summary>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="isUnitSystemChanging">if set to <c>true</c> [is unit system changing].</param>
        public UnitValueChangedEventArgs(double? oldValue, double? newValue)
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the new value.
        /// </summary>
        /// <value>The new value.</value>
        public double? NewValue { get; }

        /// <summary>
        /// Gets the old value.
        /// </summary>
        /// <value>The old value.</value>
        public double? OldValue { get; }

        #endregion Properties
    }

}