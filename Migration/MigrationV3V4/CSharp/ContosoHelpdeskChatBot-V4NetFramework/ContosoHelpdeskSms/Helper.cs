﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ContosoHelpdeskSms
{
    public class Helper
    {
        public static bool SendSms(string ToMobileNumber, string Message)
        {
            string TWILIO_ACCOUNT_SID = "";
            string TWILIO_AUTH_TOKEN = "";

            TwilioClient.Init(TWILIO_ACCOUNT_SID, TWILIO_AUTH_TOKEN);

            var message = MessageResource.Create(
                to: new PhoneNumber(ToMobileNumber),
                from: new PhoneNumber("+12062080995"),
                body: Message
                );

            return (message != null) ? true : false;
        }
    }
}