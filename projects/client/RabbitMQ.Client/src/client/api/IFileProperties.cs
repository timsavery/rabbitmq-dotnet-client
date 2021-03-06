// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 1.1.
//
// The APL v2.0:
//
//---------------------------------------------------------------------------
//   Copyright (C) 2007-2012 VMware, Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//---------------------------------------------------------------------------
//
// The MPL v1.1:
//
//---------------------------------------------------------------------------
//  The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License
//  at http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
//  the License for the specific language governing rights and
//  limitations under the License.
//
//  The Original Code is RabbitMQ.
//
//  The Initial Developer of the Original Code is VMware, Inc.
//  Copyright (c) 2007-2012 VMware, Inc.  All rights reserved.
//---------------------------------------------------------------------------

using System;
using System.Collections;

namespace RabbitMQ.Client
{
    ///<summary>Common AMQP File content-class headers interface,
    ///spanning the union of the functionality offered by versions
    ///0-8, 0-8qpid, 0-9 and 0-9-1 of AMQP.</summary>
    ///<remarks>
    ///<para>
    ///The specification code generator provides
    ///protocol-version-specific implementations of this interface. To
    ///obtain an implementation of this interface in a
    ///protocol-version-neutral way, use
    ///IModel.CreateFileProperties().
    ///</para>
    ///<para>
    ///Each property is readable, writable and clearable: a cleared
    ///property will not be transmitted over the wire. Properties on a
    ///fresh instance are clear by default.
    ///</para>
    ///</remarks>
    public interface IFileProperties : IContentHeader
    {
        /// <summary> MIME content type </summary>
        string ContentType { get; set; }

        /// <summary> MIME content encoding </summary>
        string ContentEncoding { get; set; }

        /// <summary> message header field table </summary>
        IDictionary Headers { get; set; }

        /// <summary> message priority, 0 to 9 </summary>
        byte Priority { get; set; }

        /// <summary> destination to reply to </summary>
        string ReplyTo { get; set; }

        /// <summary> application message identifier </summary>
        string MessageId { get; set; }

        /// <summary> message filename </summary>
        string Filename { get; set; }

        /// <summary> message timestamp </summary>
        AmqpTimestamp Timestamp { get; set; }

        /// <summary> intra-cluster routing identifier </summary>
        string ClusterId { get; set; }

        ///<summary> Clear the ContentType property. </summary>
        void ClearContentType();

        ///<summary> Clear the ContentEncoding property. </summary>
        void ClearContentEncoding();

        ///<summary> Clear the Headers property. </summary>
        void ClearHeaders();

        ///<summary> Clear the Priority property. </summary>
        void ClearPriority();

        ///<summary> Clear the ReplyTo property. </summary>
        void ClearReplyTo();

        ///<summary> Clear the MessageId property. </summary>
        void ClearMessageId();

        ///<summary> Clear the Filename property. </summary>
        void ClearFilename();

        ///<summary> Clear the Timestamp property. </summary>
        void ClearTimestamp();

        ///<summary> Clear the ClusterId property. </summary>
        void ClearClusterId();

        ///<summary> Returns true iff the ContentType property is present. </summary>
        bool IsContentTypePresent();

        ///<summary> Returns true iff the ContentEncoding property is present. </summary>
        bool IsContentEncodingPresent();

        ///<summary> Returns true iff the Headers property is present. </summary>
        bool IsHeadersPresent();

        ///<summary> Returns true iff the Priority property is present. </summary>
        bool IsPriorityPresent();

        ///<summary> Returns true iff the ReplyTo property is present. </summary>
        bool IsReplyToPresent();

        ///<summary> Returns true iff the MessageId property is present. </summary>
        bool IsMessageIdPresent();

        ///<summary> Returns true iff the Filename property is present. </summary>
        bool IsFilenamePresent();

        ///<summary> Returns true iff the Timestamp property is present. </summary>
        bool IsTimestampPresent();

        ///<summary> Returns true iff the ClusterId property is present. </summary>
        bool IsClusterIdPresent();
    }
}