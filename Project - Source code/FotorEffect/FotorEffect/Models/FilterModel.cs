using Nokia.Graphics.Imaging;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FotorEffect
{
    public abstract class FilterModel
    {
        #region Properties

         
        public string Name { get; set; }

         
        abstract public Queue<IFilter> Components { get; }

        #endregion
    }

  

    public class AntiqueFilterModel : FilterModel
    {
        public AntiqueFilterModel()
        {
            Name = "Antique";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new AntiqueFilter());
                return components;
            }
        }
    }

    public class AutoEnhanceFilterModel : FilterModel
    {
        public AutoEnhanceFilterModel()
        {
            Name = "Auto Enhance";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new AutoEnhanceFilter(true, true));

                return components;
            }
        }
    }

    public class AutoLevelsFilterModel : FilterModel
    {
        public AutoLevelsFilterModel()
        {
            Name = "Auto Levels";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new AutoLevelsFilter());

                return components;
            }
        }
    }

    public class BlendFilterModel : FilterModel
    {
        public BlendFilterModel()
        {
            Name = "Blend";
        }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new BlendFilter());
                return components;
            }
        }
    }

    public class BlurFilterModel : FilterModel
    {
        public BlurFilterModel()
        {
            Name = "Blur";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new BlurFilter(5));

                return components;
            }
        }
    }

    public class BrightnessFilterModel : FilterModel
    {
        public BrightnessFilterModel()
        {
            Name = "Brightness";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new BrightnessFilter(0.35f));

                return components;
            }
        }
    }

    public class CartoonFilterModel : FilterModel
    {
        public CartoonFilterModel()
        {
            Name = "Cartoon";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new CartoonFilter(true));

                return components;
            }
        }
    }

    public class ChromaKeyFilterModel : FilterModel
    {
        public ChromaKeyFilterModel()
        {
            Name = "Chroma Key";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new ChromaKeyFilter());

                return components;
            }
        }
    }

    public class ColorBoostFilterModel : FilterModel
    {
        public ColorBoostFilterModel()
        {
            Name = "Color Boost";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new ColorBoostFilter(3.0f));

                return components;
            }
        }
    }

    public class ColorizationFilterModel : FilterModel
    {
        public ColorizationFilterModel()
        {
            Name = "Colorization";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new ColorizationFilter());
                return components;
            }
        }
    }

    public class ContrastFilterModel : FilterModel
    {
        public ContrastFilterModel()
        {
            Name = "Contrast";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new ContrastFilter(0.8f));

                return components;
            }
        }
    }

    public class CurvesFilterModel : FilterModel
    {
        public CurvesFilterModel()
        {
            Name = "Curves";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new CurvesFilter());

                return components;
            }
        }
    }


    public class DespeckleFilterModel : FilterModel
    {
        public DespeckleFilterModel()
        {
            Name = "Despeckle";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new DespeckleFilter(DespeckleLevel.High));

                return components;
            }
        }
    }

    public class EmbossFilterModel : FilterModel
    {
        public EmbossFilterModel()
        {
            Name = "Emboss";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new EmbossFilter(1.0f));

                return components;
            }
        }
    }


    public class ExposureFilterModel : FilterModel
    {
        public ExposureFilterModel()
        {
            Name = "Exposure";
        }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new ExposureFilter(ExposureMode.Natural, 0.9f));

                return components;
            }
        }
    }


    public class FlipFilterModel : FilterModel
    {
        public FlipFilterModel()
        { Name = "Flip";  }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new FlipFilter(FlipMode.Horizontal));
                return components;
            }
        }
    }

    public class FogFilterModel : FilterModel
    {
        public FogFilterModel()
        { Name = "Fog"; }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new FogFilter());
                return components;
            }
        }
    }

    public class FoundationFilterModel : FilterModel
    {
        public FoundationFilterModel()
        {
            Name = "Foundation";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new FoundationFilter());
                return components;
            }
        }
    }

    public class GrayscaleFilterModel : FilterModel
    {
        public GrayscaleFilterModel()
        {Name = "Grayscale";}
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new GrayscaleFilter());
                return components;
            }
        }
    }

    public class GrayscaleNegativeFilterModel : FilterModel
    {
        public GrayscaleNegativeFilterModel()
        { Name = "Grayscale Negative"; }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new GrayscaleNegativeFilter());
                return components;
            }
        }
    }

    public class HueSaturationFilterModel : FilterModel
    {
        public HueSaturationFilterModel()
        {Name = "Hue Saturation";}
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new HueSaturationFilter(0.9, 0.9));
                return components;
            }
        }
    }

    public class ImageFusionFilterModel : FilterModel
    {
        public ImageFusionFilterModel()
        { Name = "Image Fusion"; }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new ImageFusionFilter());
                return components;
            }
        }
    }

    public class LevelsFilterModel : FilterModel
    {
        public LevelsFilterModel()
        { Name = "Levels"; }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new LevelsFilter(0.7f, 0.2f, 0.4f));
                return components;
            }
        }
    }

    public class LocalBoostFilterModel : FilterModel
    {
        public LocalBoostFilterModel()
        {
            Name = "Local Boost";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new LocalBoostAutomaticFilter());
                return components;
            }
        }
    }

    public class LomoFilterModel : FilterModel
    {
        public LomoFilterModel()
        {
            Name = "Lomo";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new LomoFilter(0.5f, 0.75f, LomoVignetting.Medium, LomoStyle.Neutral));

                return components;
            }
        }
    }

    public class MagicPenFilterModel : FilterModel
    {
        public MagicPenFilterModel()
        {
            Name = "Magic Pen";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MagicPenFilter());

                return components;
            }
        }
    }

    public class MilkyFilterModel : FilterModel
    {
        public MilkyFilterModel()
        {
            Name = "Milky";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MilkyFilter());

                return components;
            }
        }
    }

    public class MirrorFilterModel : FilterModel
    {
        public MirrorFilterModel()
        {
            Name = "Mirror";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MirrorFilter());

                return components;
            }
        }
    }

    public class MonocolorRedFilterModel : FilterModel
    {
        public MonocolorRedFilterModel()
        {
            Name = "Monocolor Red";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MonoColorFilter(new Windows.UI.Color() { R = 0xff, G = 0x00, B = 0x00 }, 0.3));

                return components;
            }
        }
    }

    public class MonocolorGreenFilterModel : FilterModel
    {
        public MonocolorGreenFilterModel()
        {
            Name = "Monocolor Green";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MonoColorFilter(new Windows.UI.Color() { R = 0x00, G = 0xff, B = 0x00 }, 0.3));

                return components;
            }
        }
    }

    public class MonocolorBlueFilterModel : FilterModel
    {
        public MonocolorBlueFilterModel()
        {
            Name = "Monocolor Blue";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MonoColorFilter(new Windows.UI.Color() { R = 0x00, G = 0x00, B = 0xff }, 0.3));

                return components;
            }
        }
    }

    public class MoonlightFilterModel : FilterModel
    {
        public MoonlightFilterModel()
        {
            Name = "Moonlight";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new MoonlightFilter(21));

                return components;
            }
        }
    }

    public class NegativeFilterModel : FilterModel
    {
        public NegativeFilterModel()
        {
            Name = "Negative";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new NegativeFilter());
                return components;
            }
        }
    }

    public class NoiseFilterModel : FilterModel
    {
        public NoiseFilterModel()
        {
            Name = "Noise";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new NoiseFilter());
                return components;
            }
        }
    }


    public class OilyFilterModel : FilterModel
    {
        public OilyFilterModel()
        {
            Name = "Oily";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new OilyFilter());

                return components;
            }
        }
    }

    public class PaintFilterModel : FilterModel
    {
        public PaintFilterModel()
        {
            Name = "Paint";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new PaintFilter(1));

                return components;
            }
        }
    }

    public class PosterizeFilterModel : FilterModel
    {
        public PosterizeFilterModel()
        {
            Name = "Posterize";
        }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new PosterizeFilter(8));

                return components;
            }
        }
    }

    public class SepiaFilterModel : FilterModel
    {
        public SepiaFilterModel()
        {
            Name = "Sepia";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new SepiaFilter());

                return components;
            }
        }
    }

    public class SharpnessFilterModel : FilterModel
    {
        public SharpnessFilterModel()
        {
            Name = "Sharpness";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new SharpnessFilter(4));

                return components;
            }
        }
    }

    public class SketchFilterModel : FilterModel
    {
        public SketchFilterModel()
        {
            Name = "Sketch";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new SketchFilter(SketchMode.Color));

                return components;
            }
        }
    }

    public class SolarizeFilterModel : FilterModel
    {
        public SolarizeFilterModel()
        {
            Name = "Solarize";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new SolarizeFilter(0.5f));

                return components;
            }
        }
    }



    public class StampFilterModel : FilterModel
    {
        public StampFilterModel()
        {
            Name = "Stamp";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new StampFilter(3, 60));

                return components;
            }
        }
    }

    public class RotationFilterModel : FilterModel
    {
        public double Value { get; set; }
        public RotationFilterModel(double value)
        {
            Name = "Rotate";
            Value = value;
        }

        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();
                components.Enqueue(new RotationFilter(Value));
                return components;
            }
        }
    }

    //public class StepRotationLeftFilterModel : FilterModel
    //{
    //    public StepRotationLeftFilterModel()
    //    {
    //        Name = "Rotate left";
    //    }

         
    //    public override Queue<IFilter> Components
    //    {
    //        get
    //        {
    //            Queue<IFilter> components = new Queue<IFilter>();

    //            components.Enqueue(new RotationFilter(270));

    //            return components;
    //        }
    //    }
    //}

    //public class StepRotationRightFilterModel : FilterModel
    //{
    //    public StepRotationRightFilterModel()
    //    {
    //        Name = "Rotate right";
    //    }

         
    //    public override Queue<IFilter> Components
    //    {
    //        get
    //        {
    //            Queue<IFilter> components = new Queue<IFilter>();

    //            components.Enqueue(new RotationFilter(90));

    //            return components;
    //        }
    //    }
    //}

    public class WarpTwisterFilterModel : FilterModel
    {
        public WarpTwisterFilterModel()
        {
            Name = "Warp Twister";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new WarpFilter(WarpEffect.Twister, 0.3f));

                return components;
            }
        }
    }

    public class WatercolorFilterModel : FilterModel
    {
        public WatercolorFilterModel()
        {
            Name = "Watercolor";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new WatercolorFilter(0.8f, 0.5f));

                return components;
            }
        }
    }

    public class VignettingFilterModel : FilterModel
    {
        public VignettingFilterModel()
        {
            Name = "Vignetting";
        }

         
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new VignettingFilter(0.4f, Windows.UI.Color.FromArgb(0xff, 0x00, 0x00, 0x00)));

                return components;
            }
        }
    }

 
    public class TemperatureAndTintFilterModel : FilterModel
    {
        public TemperatureAndTintFilterModel()
        {
            Name = "Temperature & Tint";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new TemperatureAndTintFilter(0.8, -0.4));

                return components;
            }
        }
    }

    public class WhiteboardEnhancementFilterModel : FilterModel
    {
        public WhiteboardEnhancementFilterModel()
        {
            Name = "Whiteboard";
        }
        public override Queue<IFilter> Components
        {
            get
            {
                Queue<IFilter> components = new Queue<IFilter>();

                components.Enqueue(new WhiteboardEnhancementFilter(WhiteboardEnhancementMode.Soft));

                return components;
            }
        }
    }

   
}
