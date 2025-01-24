using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Common.Enums
{
    public class RoomStatusDefinition
    {
        private RoomStatusDefinition(string value) { Value = value; }

        public string Value { get; }

        public static RoomStatusDefinition RUN => new RoomStatusDefinition("RUN");
        public static RoomStatusDefinition SLEEP => new RoomStatusDefinition("SLEEP");
        public static RoomStatusDefinition END => new RoomStatusDefinition("END");
        // ...

        public static implicit operator string(RoomStatusDefinition enumValue)
        {
            return enumValue.Value;
        }

        public static explicit operator RoomStatusDefinition(string stringValue)
        {
            if (stringValue == RUN) return RUN;
            if (stringValue == SLEEP) return SLEEP;
            if (stringValue == END) return END;
            // ...

            throw new InvalidCastException($"Invalid string value for StringEnum: {stringValue}");
        }
    }

}
