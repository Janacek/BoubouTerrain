using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoubouTerrain
{

    [ExecuteInEditMode]
    public class Chunk : MonoBehaviour
    {
        #region Public

        public Graph G
        {
            get { return m_graph; }
        }

        #endregion

        public void Start()
        {
            Init();
        }

        public void Init()
        {
            Debug.Log("Init Chunk");
            m_graph = new Graph();

            ControlPoint cp1 = m_graph.CreateNewControlPoint(new Vector2(0, 0));
            ControlPoint cp2 = m_graph.CreateNewControlPoint(new Vector2(0, 3));
            ControlPoint cp3 = m_graph.CreateNewControlPoint(new Vector2(3, 3));
            ControlPoint cp4 = m_graph.CreateNewControlPoint(new Vector2(3, 0));

            cp1.SetNeighbours(cp2, cp4);
            cp2.SetNeighbours(cp3, cp1);
            cp3.SetNeighbours(cp4, cp2);
            cp4.SetNeighbours(cp1, cp3);
        }

        public void OnEnable()
        {
            Init();
        }

        void OnGUI()
        {
        }

        void Update()
        {

        }

        void OnDrawGizmos()
        {
            if (m_graph == null)
                return;
            m_graph.ControlPoints.ForEach(cp =>
            {
                Gizmos.DrawIcon(cp.Position, "ControlPointIcon.bmp", false);
                Gizmos.DrawIcon(Vector2.Lerp(cp.Position, cp.GetNeighbour(ControlPoint.e_Side.LeftNode).Position, 0.5f), "MidDot.png", false);
                Gizmos.DrawLine(cp.Position, cp.GetNeighbour(ControlPoint.e_Side.LeftNode).Position);
            });
        }

        #region Private

        Graph m_graph;

        #endregion
    }

}