#version 330

in vec2 vTexCoord;

out vec4 oColor;

uniform sampler2D tex0;
uniform highp vec4 uColor;

void main() {
  vec4 texColor = texture(tex0, vTexCoord);
  if (texColor.a < 0.5) discard;
  oColor = texColor * uColor;
}
