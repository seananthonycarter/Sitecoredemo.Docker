# escape=`

ARG PARENT_IMAGE
ARG SXA_IMAGE

FROM ${SXA_IMAGE} as sxa
FROM ${PARENT_IMAGE}

# Add SXA module
COPY --from=sxa C:\module\solr\cores-sxa.json C:\data\cores-sxa.json
