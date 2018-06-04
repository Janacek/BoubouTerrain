using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoubouTerrain
{

    public class Graph
    {
        #region Public

        public List<ControlPoint> ControlPoints
        {
            get { return m_controlPoints; }
        }

        #endregion

        #region Public Methods

        public ControlPoint CreateNewControlPoint(Vector2 position)
        {
            ControlPoint cp = new ControlPoint();
            cp.Position = position;
            m_controlPoints.Add(cp);
            return cp;
        }

        #endregion

        #region Private

        List<ControlPoint> m_controlPoints = new List<ControlPoint>();

        #endregion
    }

}
