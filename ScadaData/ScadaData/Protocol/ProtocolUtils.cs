﻿/*
 * Copyright 2020 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaData
 * Summary  : Provides constants and helper methods for the application protocol
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2020
 */

namespace Scada.Protocol
{
    /// <summary>
    /// Provides constants and helper methods for the application protocol.
    /// <para>Предоставляет константы и вспомогательные методы для протокола приложения.</para>
    /// </summary>
    public static class ProtocolUtils
    {
        /// <summary>
        /// The packet header length.
        /// </summary>
        public const int HeaderLength = 14;
        /// <summary>
        /// The index of the function arguments in the data packet.
        /// </summary>
        public const int ArgumentIndex = 16;
    }
}
