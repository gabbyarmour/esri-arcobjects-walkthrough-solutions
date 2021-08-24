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
        public void ZoomToActiveLayerInTOC(IMxDocument mxDocument)
        {
            if (mxDocument == null)
            {
                return;
            }
            IActiveView activeView = mxDocument.ActiveView;

            // Get the TOC
            IContentsView IContentsView = mxDocument.CurrentContentsView;

            // Get the selected layer
            System.Object selectedItem = IContentsView.SelectedItem;
            if (!(selectedItem is ILayer))
            {
                return;
            }
            ILayer layer = selectedItem as ILayer;


            // Zoom to the extent of the layer and refresh the map
            activeView.Extent = layer.AreaOfInterest;
            activeView.Refresh();
        }
        #endregion
    }
}

// Note: Most of this code has already been generated. It just needs to be put together.
