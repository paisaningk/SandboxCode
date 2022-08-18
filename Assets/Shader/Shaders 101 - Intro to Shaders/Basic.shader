// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Shaders101/Basic"
{
   Properties
    {
        _Color ("Color", Color) = (0.26,0.19,0.16,0.0)
        _MainTex ("Texture", 2D) = "white"
    }
    SubShader
    {
        Tags
        {
            "Queue" = "Transparent"
            "PreviewType" = "Plane"
        }
        
        Blend SrcAlpha OneMinusSrcAlpha
        
        Pass
        {
            CGPROGRAM

           #pragma vertex vert
           #pragma fragment frag

           #include "UnityCG.cginc"

           struct appdata
           {
               float4 vertex : POSITION;
               float2 uv : TEXCOORD0;
           };

           struct v2f
           {
               float4 vertex : SV_POSITION;
               float2 uv : TEXCOORD0;
           };


           float4 _Color;
           sampler2D _MainTex; 

           v2f vert(appdata v)
           {
               v2f o;
               o.vertex = UnityObjectToClipPos(v.vertex);
               o.uv = v.uv;
               return o;
           }

           float4 frag(v2f i) : SV_Target
           {
               float4 Color = tex2D(_MainTex, i.uv);
               return Color;
           }
           
           ENDCG
        }
        
    }

     
}
