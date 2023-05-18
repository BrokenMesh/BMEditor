#version 330 core
layout (location = 0) in vec3 a_Position;
layout (location = 2) in vec4 a_Color;
layout (location = 3) in vec4 a_BGColor;

out vec4 v_Color;          

uniform mat4 u_Projection;
uniform mat4 u_Model;

void main()
{
    gl_Position = u_Projection * u_Model * vec4(a_Position.xyz, 1.0);

    v_Color = a_Color;
}
