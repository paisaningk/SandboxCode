// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/First TIME"
{
	Properties {
		_Tint ("Tint", Color) = (1, 1, 1, 1)
	}
    SubShader {
    	
		Pass {
//			CGPROGRAM
//
//			#ifdef VERTEX
//			void main()
//			{
//				gl_Position = in_POSITION0;;
//			    return;
//			}
//			#endif
//			#ifdef FRAGMENT
//			void main()
//			{
//			    SV_TARGET0.xyz = vs_TEXCOORD0.xyz;
//			    SV_TARGET0.w = 1.0;
//			    return;
//			}
//			#endif
//			
//			#pragma vertex MyVertexProgram
//			#pragma fragment MyFragmentProgram
//			#include "UnityCG.cginc"
//
//			float4 _Tint;
//			
//			float4 MyVertexProgram (float4 position : POSITION) : SV_POSITION {
//				return UnityObjectToClipPos(position);
//			}
//
//			float4 MyVertexProgram (
//				float4 position : POSITION,
//				out float3 localPosition : TEXCOORD0
//			) : SV_POSITION {
//				localPosition = position.xyz;
//				return UnityObjectToClipPos(position);
//			}
//			
//			ENDCG
		}
	}
	
	
}
