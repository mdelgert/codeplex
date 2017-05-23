/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
* Copyright © 2013 Matthew David Elgert mdelgert@hotmail.com, All Rights Reserved. 
*
* NOTICE: All information contained herein is, and remains the property of Matthew Elgert. The intellectual and technical concepts contained
* herein are proprietary to Matthew Elgert and may be covered by U.S. and Foreign Patents, patents in process, and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material is strictly forbidden unless prior written permission is obtained
* from Matthew Elgert. Access to the source code contained herein is hereby forbidden to anyone except Matthew Elgert or contractors who have executed 
* Confidentiality and Non-disclosure agreements explicitly covering such access.
*
* The copyright notice above does not evidence any actual or intended publication or disclosure of this source code, which includes
* information that is confidential and/or proprietary, and is a trade secret, of Matthew Elgert. ANY REPRODUCTION, MODIFICATION, DISTRIBUTION, PUBLICPERFORMANCE, 
* OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE WITHOUT THE EXPRESS WRITTEN CONSENT OF Matthew Elgert IS STRICTLY PROHIBITED, AND IN VIOLATION OF APPLICABLE 
* LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OFTHIS SOURCE CODE AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS
* TO REPRODUCE, DISCLOSE OR DISTRIBUTE ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT ITMAY DESCRIBE, IN WHOLE OR IN PART.
*
* Author: Matthew David Elgert
*
* Authored date: 11/26/2013
* 
* ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

using System;
using System.IO;
using System.Linq;
using Base.Core.EntityDataModel;

namespace Base.Core.BusinessLogic
{
    public class SwitchLayer
    {
        /// <summary>
        /// Switch CRUD operations
        /// </summary>

        public void Create(Switch _modelSwitch)
        {
            using (var context = new DBEntities())
            {
                _modelSwitch.InsertDT = System.DateTime.Now;
                _modelSwitch.LastUpdated = System.DateTime.Now;
                context.Switches.Add(_modelSwitch);
                context.SaveChanges();
            }
        }

        public Switch Read(int _keyID)
        {
            Switch _oModel = new Switch();

            using (var context = new DBEntities())
            {
                _oModel = context.Switches.Find(_keyID);
            }

            return _oModel;
        }

        public void Update(Switch _modelViewSwitch)
        {
            using (var context = new DBEntities())
            {
                var _oModel = context.Switches.Find(_modelViewSwitch.RecordID);
                _oModel.LastUpdated = System.DateTime.Now;
                _oModel.SwitchDescription = _modelViewSwitch.SwitchDescription;
                _oModel.SwitchStatus = _modelViewSwitch.SwitchStatus;
                context.SaveChanges();
            }
        }

        public void Delete(Switch _modelViewSwitch)
        {
            using (var context = new DBEntities())
            {
                var _oModel = context.Switches.Find(_modelViewSwitch.RecordID);
                context.Switches.Remove(_oModel);
                context.SaveChanges();
            }
        }

        public void UpdateStatus(Switch _modelViewSwitch)
        {
            using (var context = new DBEntities())
            {
                var _oModel = context.Switches.Find(_modelViewSwitch.RecordID);
                _oModel.LastUpdated = System.DateTime.Now;
                _oModel.SwitchStatus = _modelViewSwitch.SwitchStatus;
                context.SaveChanges();
            }
        }

        public bool? SwitchStatus(int _keyID)
        {
            Switch _oModel = new Switch();

            using (var context = new DBEntities())
            {
                _oModel = context.Switches.Find(_keyID);
            }

            return _oModel.SwitchStatus;
        }

    }

}
