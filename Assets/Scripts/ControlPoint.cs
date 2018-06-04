using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoubouTerrain
{

    public class ControlPoint
    {
        #region Enum

        public enum e_Side
        {
            LeftNode = 0,
            RightNode = 1,
        }

        #endregion

        #region Public

        public Vector2 Position
        {
            get { return m_position; }
            set { m_position = value; }
        }

        #endregion

        #region Public Methods

        public void SetNeighbour(ControlPoint neighbour, e_Side side)
        {
            if (side == e_Side.LeftNode)
                m_leftNeighbour = neighbour;
            else
                m_rightNeighbour = neighbour;
        }

        public void SetNeighbours(ControlPoint lhs, ControlPoint rhs)
        {
            m_rightNeighbour = rhs;
            m_leftNeighbour = lhs;
        }

        public ControlPoint GetNeighbour(e_Side side)
        {
            return side == e_Side.LeftNode ? m_leftNeighbour : m_rightNeighbour;
        }

        #endregion

        #region Private Methods
        #endregion

        #region Private

        Vector2 m_position;

        ControlPoint m_leftNeighbour = null;
        ControlPoint m_rightNeighbour = null;

        #endregion
    }

}