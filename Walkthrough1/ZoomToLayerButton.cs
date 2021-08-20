using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace AddInCustomUIElements
{
    public class ZoomToLayerButton : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomToLayerButton()
        {
        }

        protected override void OnClick()
        {
            ZoomToActiveLayerInTOC(ArcMap.Application.Document as IMxDocument);
            ArcMap.Application.CurrentTool = null;
        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }

        #region
        public void ZoomToActiveLayerInTOC(ESRI.ArcGIS.ArcMapUI.IMxDocument mxDocument)
        {
            if (mxDocument == null)
            {
                return;
            }
            ESRI.ArcGIS.Carto.IActiveView activeView = mxDocument.ActiveView;

            // Get the TOC
            ESRI.ArcGIS.ArcMapUI.IContentsView IContentsView = mxDocument.CurrentContentsView;

            // Get the selected layer
            System.Object selectedItem = IContentsView.SelectedItem;
            if (!(selectedItem is ESRI.ArcGIS.Carto.ILayer))
            {
                return;
            }
            ESRI.ArcGIS.Carto.ILayer layer = selectedItem as ESRI.ArcGIS.Carto.ILayer;


            // Zoom to the extent of the layer and refresh the map
            activeView.Extent = layer.AreaOfInterest;
            activeView.Refresh();
        }
        #endregion
    }

}
