using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LogisTechBase
{
    public partial class MatrixCircular1 : UserControl
    {
        #region Constants

        private const int DefaultInterval = 60;
        private readonly Color _defaultTickColor = Color.FromArgb(58, 58, 58);
        private const int DefaultTickWidth = 2;
        private const int MinimumInnerRadius = 4;
        private const int MinimumOuterRadius = 8;
        private Size _minimumControlSize = new Size(28, 28);
        private const int MinimumPenWidth = 2;
        private const float InnerRadiusFactor = 0.175F;
        private const float OuterRadiusFactor = 0.3125F;

        #endregion

        #region Enums

        public enum Direction
        {
            Clockwise,
            Anticlockwise
        }

        #endregion

        #region Structs

        struct Spoke
        {
            public PointF StartPoint;
            public PointF EndPoint;

            public Spoke(PointF pt1, PointF pt2)
            {
                StartPoint = pt1;
                EndPoint = pt2;
            }
        }

        #endregion

        #region Members

        private int _mInterval;
        Pen _mPen = null;
        PointF _mCentrePt = new PointF();
        int _mInnerRadius = 0;
        int _mOuterRadius = 0;
        int _mSpokesCount = 0;
        int _mAlphaChange = 0;
        int _mAlphaLowerLimit = 0;
        float _mStartAngle = 0;
        float _mAngleIncrement = 0;
        Direction _mRotation;
        System.Timers.Timer _mTimer = null;
        List<Spoke> _mSpokes = null;

        #endregion

        #region Properties

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        public int Interval
        {
            get
            {
                return _mInterval;
            }
            set
            {
                if (value > 0)
                {
                    _mInterval = value;
                }
                else
                {
                    _mInterval = DefaultInterval;
                }
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        public Color TickColor { get; set; }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        public Direction Rotation
        {
            get
            {
                return _mRotation;
            }
            set
            {
                _mRotation = value;
                CalculateSpokesPoints();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        public float StartAngle
        {
            get
            {
                return _mStartAngle;
            }
            set
            {
                _mStartAngle = value;
            }
        }

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Ctor
        /// </summary>
        public MatrixCircular1()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            // Set Default Values
            this.BackColor = Color.Transparent;
            this.TickColor = _defaultTickColor;
            this.MinimumSize = _minimumControlSize;
            this.Interval = DefaultInterval;
            // Default starting angle is 12 o'clock
            this.StartAngle = 270;
            // Default number of Spokes in this control is 12
            _mSpokesCount = 12;
            // Set the Lower limit of the Alpha value (The spokes will be shown in 
            // alpha values ranging from 255 to m_AlphaLowerLimit)
            _mAlphaLowerLimit = 15;

            // Create the Pen
            _mPen = new Pen(TickColor, DefaultTickWidth);
            _mPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            _mPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            // Default rotation direction is clockwise
            this.Rotation = Direction.Clockwise;

            // Calculate the Spoke Points
            CalculateSpokesPoints();

            _mTimer = new System.Timers.Timer(this.Interval);
            _mTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerElapsed);
        }

        /// <summary>
        /// Calculate the Spoke Points and store them
        /// </summary>
        private void CalculateSpokesPoints()
        {
            _mSpokes = new List<Spoke>();

            // Calculate the angle between adjacent spokes
            _mAngleIncrement = (360 / (float)_mSpokesCount);
            // Calculate the change in alpha between adjacent spokes
            _mAlphaChange = (int)((255 - _mAlphaLowerLimit) / _mSpokesCount);

            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            _mCentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            _mPen.Width = (int)(width / 15);
            if (_mPen.Width < MinimumPenWidth)
                _mPen.Width = MinimumPenWidth;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            _mInnerRadius = (int)(width * InnerRadiusFactor);
            if (_mInnerRadius < MinimumInnerRadius)
                _mInnerRadius = MinimumInnerRadius;
            _mOuterRadius = (int)(width * OuterRadiusFactor);
            if (_mOuterRadius < MinimumOuterRadius)
                _mOuterRadius = MinimumOuterRadius;

            float angle = 0;

            for (int i = 0; i < _mSpokesCount; i++)
            {
                PointF pt1 = new PointF(_mInnerRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), _mInnerRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(_mOuterRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), _mOuterRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));

                // Create a spoke based on the points generated
                Spoke spoke = new Spoke(pt1, pt2);
                // Add the spoke to the List
                _mSpokes.Add(spoke);

                if (Rotation == Direction.Clockwise)
                {
                    angle -= _mAngleIncrement;
                }
                else if (Rotation == Direction.Anticlockwise)
                {
                    angle += _mAngleIncrement;
                }
            }
        }

        #endregion

        #region EventHandlers

        /// <summary>
        /// Handler for the event when the size of the control changes
        /// </summary>
        /// <param name="e">EventArgs</param>
        protected override void OnClientSizeChanged(EventArgs e)
        {
            CalculateSpokesPoints();
        }

        /// <summary>
        /// Handle the Tick event
        /// </summary>
        /// <param name="sender">Timer</param>
        /// <param name="e">ElapsedEventArgs</param>
        void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Rotation == Direction.Clockwise)
            {
                _mStartAngle += _mAngleIncrement;

                if (_mStartAngle >= 360)
                    _mStartAngle = 0;
            }
            else if (Rotation == Direction.Anticlockwise)
            {
                _mStartAngle -= _mAngleIncrement;

                if (_mStartAngle <= -360)
                    _mStartAngle = 0;
            }

            Invalidate();
        }


        /// <summary>
        /// Handles the Paint Event of the control
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // Perform a Translation so that the centre of the control is the centre of Rotation
            e.Graphics.TranslateTransform(_mCentrePt.X, _mCentrePt.Y, System.Drawing.Drawing2D.MatrixOrder.Prepend);
            // Perform a Rotation about the control's centre
            e.Graphics.RotateTransform(_mStartAngle, System.Drawing.Drawing2D.MatrixOrder.Prepend);

            int alpha = 255;

            // Render the spokes
            for (int i = 0; i < _mSpokesCount; i++)
            {
                _mPen.Color = Color.FromArgb(alpha, this.TickColor);
                e.Graphics.DrawLine(_mPen, _mSpokes[i].StartPoint, _mSpokes[i].EndPoint);

                alpha -= _mAlphaChange;
                if (alpha < _mAlphaLowerLimit)
                    alpha = 255 - _mAlphaChange;
            }

            // Perform a reverse Rotation and Translation to obtain the original Transformation
            e.Graphics.RotateTransform(-_mStartAngle, System.Drawing.Drawing2D.MatrixOrder.Append);
            e.Graphics.TranslateTransform(-_mCentrePt.X, -_mCentrePt.Y, System.Drawing.Drawing2D.MatrixOrder.Append);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Converts Degrees to Radians
        /// </summary>
        /// <param name="degrees">Degrees</param>
        /// <returns></returns>
        private double ConvertDegreesToRadians(float degrees)
        {
            return ((Math.PI / (double)180) * degrees);
        }

        #endregion

        #region APIs

        /// <summary>
        /// Start the Tick Control rotation
        /// </summary>
        public void Start()
        {
            if (_mTimer != null)
            {
                _mTimer.Interval = this.Interval;
                _mTimer.Enabled = true;
            }
        }

        /// <summary>
        /// Stop the Tick Control rotation
        /// </summary>
        public void Stop()
        {
            if (_mTimer != null)
            {
                _mTimer.Enabled = false;
            }
        }

        #endregion
    }
}
