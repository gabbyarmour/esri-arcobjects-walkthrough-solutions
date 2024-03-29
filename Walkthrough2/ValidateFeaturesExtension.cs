﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Desktop;
using ESRI.ArcGIS.Geodatabase;

namespace AddInEditorExtension
{
    /// <summary>
    /// ValidateFeaturesExtension class implementing custom ESRI Editor Extension functionalities.
    /// </summary>
    public class ValidateFeaturesExtension : ESRI.ArcGIS.Desktop.AddIns.Extension
    {
        public ValidateFeaturesExtension()
        {
        }

        protected override void OnStartup()
        {
            // IEditor theEditor = ArcMap.Editor;
            Events.OnStartEditing += new IEditEvents_OnStartEditingEventHandler
                (Events_OnStartEditing);
            Events.OnStopEditing += new IEditEvents_OnStopEditingEventHandler
                (Events_OnStopEditing);
        }

        //Invoked at the start of an editor session.
        void Events_OnStartEditing()
        {
            //Since features of shapefiles, coverages, and so on, cannot be validated, ignore wiring 
            //events for them.
            if (ArcMap.Editor.EditWorkspace.Type !=
                esriWorkspaceType.esriFileSystemWorkspace)
            {
                //Wire OnCreateFeature edit event.
                Events.OnCreateFeature += new IEditEvents_OnCreateFeatureEventHandler
                    (Events_OnCreateChangeFeature);
                //Wire onChangeFeature edit event.
                Events.OnChangeFeature += new IEditEvents_OnChangeFeatureEventHandler
                    (Events_OnCreateChangeFeature);
            }
        }

        //Invoked at the end of an editor session (Editor->Stop Editing).
        void Events_OnStopEditing(bool Save)
        {
            //Since features of shapefiles, coverages, and so on, cannot be validated, ignore wiring 
            //events for them.
            if (ArcMap.Editor.EditWorkspace.Type !=
                esriWorkspaceType.esriFileSystemWorkspace)
            {
                //Unwire OnCreateFeature edit event.
                Events.OnCreateFeature -= new IEditEvents_OnCreateFeatureEventHandler
                    (Events_OnCreateChangeFeature);
                //Unwire onChangeFeature edit event.
                Events.OnChangeFeature -= new IEditEvents_OnChangeFeatureEventHandler
                    (Events_OnCreateChangeFeature);
            }
        }

        //Invoked when a feature is created or modified.
        void Events_OnCreateChangeFeature(IObject obj)
        {
            IFeature inFeature = (IFeature)obj;
            if (inFeature.Class is IValidation)
            {
                IValidate validate = (IValidate)inFeature;
                string errorMessage;
                //Validates connectivity rules, relationship rules, topology rules, and so on.
                bool bIsvalid = validate.Validate(out errorMessage);
                //Report validation result.
                if (!bIsvalid)
                {
                    MessageBox.Show("Invalid Feature\n\n" +
                        errorMessage);
                }
                else
                {
                    MessageBox.Show("Valid Feature");
                }
            }
        }

        // Auto-generated - There is nothing to do upon shutdown
        protected override void OnShutdown()
        {
        }

        // Editor Events - Left as Default
        #region Editor Events

        #region Shortcut properties to the various editor event interfaces
        private IEditEvents_Event Events
        {
            get { return ArcMap.Editor as IEditEvents_Event; }
        }
        private IEditEvents2_Event Events2
        {
            get { return ArcMap.Editor as IEditEvents2_Event; }
        }
        private IEditEvents3_Event Events3
        {
            get { return ArcMap.Editor as IEditEvents3_Event; }
        }
        private IEditEvents4_Event Events4
        {
            get { return ArcMap.Editor as IEditEvents4_Event; }
        }
        #endregion

        void WireEditorEvents()
        {
            //
            //  TODO: Sample code demonstrating editor event wiring
            //
            Events.OnCurrentTaskChanged += delegate
            {
                if (ArcMap.Editor.CurrentTask != null)
                    System.Diagnostics.Debug.WriteLine(ArcMap.Editor.CurrentTask.Name);
            };
            Events2.BeforeStopEditing += delegate (bool save) { OnBeforeStopEditing(save); };
        }

        void OnBeforeStopEditing(bool save)
        {
        }
        #endregion

    }
}


// Note: Most of this code had already been generated. It just needs to be put together.
