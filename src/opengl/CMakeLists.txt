cmake_minimum_required(VERSION 2.6)

project (OPENGL)

get_filename_component(PARENT_DIR OPENGL PATH)

set (PROJECT_INCLUDE_DIR ${PROJECT_SOURCE_DIR}/include)
set (PROJECT_SOURCE_DIR ${CMAKE_CURRENT_SOURCE_DIR}/src)
 
file(GLOB_RECURSE OPENGL_SRC ${PROJECT_SOURCE_DIR}/*.cpp)

find_package(OpenGL REQUIRED)

include_directories(
  ${PROJECT_INCLUDE_DIR}/third-party/glfw-3.3.1/include/GLFW/
  ${PROJECT_INCLUDE_DIR}/third-party/glew-1.13.0/include/
  "${PROJECT_INCLUDE_DIR}"
  "${PROJECT_BINARY_DIR}"
  )

set(ALL_LIBS
  ${OPENGL_LIBRARY}
  glfw
  GLEW_1130)

add_subdirectory(${PROJECT_INCLUDE_DIR}/third-party)

add_library(${PROJECT_NAME} STATIC ${OPENGL_SRC})
target_link_libraries(${PROJECT_NAME} ${ALL_LIBS})
# add_subdirectory(test)
