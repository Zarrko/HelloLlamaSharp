# HelloLlamaSharp 
A tiny api that sends a bunch of images to Llama.Cpp

Request, _base64 string_: 

![Sample Image](Images/Test.jpeg)

Response: 

" The image captures an adult rhino with a calf in a field surrounded by trees. The mother rhino appears to be guiding her young as they walk together through the grassy area. There are also several birds scattered throughout the scene, flying or perched on branches among the trees. This creates a sense of movement and life within the rhino habitat."
<br>
<br>
<br>
# Setup Llama.Cpp
You will need a machine with about ~5 GB of RAM/VRAM for the q4_k version. 

(Optional) Install the CUDA toolkit:

```
sudo apt install nvidia-cuda-toolkit
```

Build llama.cpp (build instructions for various platforms at [llama.cpp build](https://github.com/ggerganov/llama.cpp#build)):

```
git clone https://github.com/ggerganov/llama.cpp
cd llama.cpp
mkdir build
cd build
cmake .. -DLLAMA_CUBLAS=ON # Remove the flag if CUDA is unavailable
cmake --build . --config Release
```

Download the models from [ggml_bakllava-1](https://huggingface.co/mys/ggml_bakllava-1/tree/main):

```
wget https://huggingface.co/mys/ggml_bakllava-1/resolve/main/mmproj-model-f16.gguf
wget https://huggingface.co/mys/ggml_bakllava-1/resolve/main/ggml-model-q4_k.gguf # Choose another quant if preferred
```

Start the server (server options detailed [here](https://github.com/ggerganov/llama.cpp/blob/master/examples/server/README.md)):

```
./bin/server -m ggml-model-q4_k.gguf --mmproj mmproj-model-f16.gguf -ngl 35 -ts 100,0 # For GPU-only, single GPU
# ./bin/server -m ggml-model-q4_k.gguf --mmproj mmproj-model-f16.gguf # For CPU
```
<br>
<br>
<br>

# Launch HelloLlamaSharp

Clone the repo, install all the dependencies and run the dotnet project

Nice intro here on getting started with ASP.Net [here](https://dotnet.microsoft.com/en-us/learn/aspnet/hello-world-tutorial/intro)
<br>
<br>
<br>

# Acknowledgement 
- [Multimodal LLama.cpp](https://github.com/ggerganov/llama.cpp/issues/3332)

