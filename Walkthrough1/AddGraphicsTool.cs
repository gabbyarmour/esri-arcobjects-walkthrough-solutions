using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace AddInCustomUIElements
{
    public class AddGraphicsTool : ESRI.ArcGIS.Desktop.AddIns.Tool
    {
        public AddGraphicsTool()
        {
        }

        protected override void OnMouseDown(ESRI.ArcGIS.Desktop.AddIns.Tool.MouseEventArgs arg)
        {
            //Get the active view from the ArcMap static class.
            IActiveView activeView = ArcMap.Document.ActiveView;
            //If it's a polyline object, get from the user's mouse clicks.
            IPolyline polyline = GetPolylineFromMouseClicks(activeView);
            //Make a color to draw the polyline. 

            IRgbColor rgbColor = new RgbColorClass();
            rgbColor.Red = 255;
            //Add the user's drawn graphics as persistent on the map.
            AddGraphicToMap(activeView.FocusMap, polyline, rgbColor, rgbColor);
            //Best practice: Redraw only the portion of the active view that contains graphics. 
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }
        
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }

        #region
        public void AddGraphicToMap(IMap map, IGeometry geometry, IRgbColor rgbColor, IRgbColor outlineRgbColor)
        {
            IGraphicsContainer graphicsContainer = (IGraphicsContainer)map; // Explicit Cast
            IElement element = null;
            if ((geometry.GeometryType) == esriGeometryType.esriGeometryPoint)
            {
                // Marker symbols
                ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
                simpleMarkerSymbol.Color = rgbColor;
                simpleMarkerSymbol.Outline = true;
                simpleMarkerSymbol.OutlineColor = outlineRgbColor;
                simpleMarkerSymbol.Size = 15;
                simpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSCircle;

                IMarkerElement markerElement = new MarkerElementClass();
                markerElement.Symbol = simpleMarkerSymbol;
                element = (IElement)markerElement; // Explicit Cast
            }
            else if ((geometry.GeometryType) == esriGeometryType.esriGeometryPolyline)
            {
                //  Line elements
                ISimpleLineSymbol simpleLineSymbol = new SimpleLineSymbolClass();
                simpleLineSymbol.Color = rgbColor;
                simpleLineSymbol.Style = esriSimpleLineStyle.esriSLSSolid;
                simpleLineSymbol.Width = 5;

                ILineElement lineElement = new LineElementClass();
                lineElement.Symbol = simpleLineSymbol;
                element = (IElement)lineElement; // Explicit Cast
            }
            else if ((geometry.GeometryType) == esriGeometryType.esriGeometryPolygon)
            {
                // Polygon elements
                ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
                simpleFillSymbol.Color = rgbColor;
                simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSForwardDiagonal;
                IFillShapeElement fillShapeElement = new PolygonElementClass();
                fillShapeElement.Symbol = simpleFillSymbol;
                element = (IElement)fillShapeElement; // Explicit Cast
            }
            if (!(element == null))
            {
                element.Geometry = geometry;
                graphicsContainer.AddElement(element, 0);
            }
        }
        #endregion

        #region
        public IPolyline GetPolylineFromMouseClicks(IActiveView activeView)
        {

                IScreenDisplay screenDisplay = activeView.ScreenDisplay;

                IRubberBand rubberBand = new RubberLineClass();
                IGeometry geometry = rubberBand.TrackNew(screenDisplay, null);

                IPolyline polyline = (IPolyline) geometry;

                return polyline;

        }
        #endregion
    }
}


// Note: Most of this code has already been generated. It just needs to be put together.
