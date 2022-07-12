Shader "Custom/Stencil Geometry"
{
    Properties
    {
        [IntRange] _StencilID ("Stencil ID", Range(0,255)) = 0
    }
    SubShader
    {
        Tags 
        { 
            "RenderType"="Opaque"
            "RenderPipline" = "UniversalPipline"
            "Queue" = "Geometry"
        }
        
        Pass
        {
            Blend Zero One
            Zwrite Off
            
            Stencil
            {
                Ref [_StencilID]
                Comp Always
                Pass Replace
                Fail Keep
            }
        }
            
    }
}
